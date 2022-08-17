using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering_Of_Color_WF
{
    class Cluster
    {
        //центроиды
        public int center_green;
        public int center_red;
        public int center_blue;
        public int last_center_green;
        public int last_center_red;
        public int last_center_blue;
        public List<Subject> c_subjectList = new List<Subject>();

        Random rnd = new Random();

        int[,,] field = new int[255, 255, 255];
        public Cluster()
        {
            while (true)
            {
                center_blue = rnd.Next(0, 255);
                center_green = rnd.Next(0, 255);
                center_red = rnd.Next(0, 255);

                //устанавливаем расстояние между кластерами в 10 по всем координатам
                int free_field = 1;
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        for (int k = 0; k < 10; k++)
                        {
                            if (center_green + i >= field.GetLength(0) || center_green - i < 0 ||
                                center_red + j >= field.GetLength(1) || center_red - j < 0 ||
                                center_blue + k >= field.GetLength(2) || center_blue - k < 0)
                                continue;
                            else if (field[center_green + i, center_red + j, center_blue + k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green - i, center_red - j, center_blue - k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green + i, center_red - j, center_blue - k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green - i, center_red + j, center_blue - k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green - i, center_red - j, center_blue + k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green + i, center_red + j, center_blue - k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green + i, center_red - j, center_blue + k] == 1)
                            {
                                free_field = 0;
                            }
                            else if (field[center_green - i, center_red + j, center_blue + k] == 1)
                            {
                                free_field = 0;
                            }
                        }

                if (free_field == 0)
                    continue;
                else
                {
                    field[center_green, center_red, center_blue] = 1;
                    break;
                }
            }
        }
    }
}
