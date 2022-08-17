using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering_Of_Color_WF
{
    class Subject_Ranging
    {
        Random rnd = new Random();
        public void Ranging(int num_of_subject, int num_of_clusters, out List<Cluster> clusterList)
        {
            //задаем выборку
            List<Subject> subjectList = new List<Subject>();
            for (int i = 0; i < num_of_subject; i++)
            {
                Subject subject = new Subject(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                subjectList.Add(subject);
            }

            //задаем кластеры и их центроиды
            clusterList = new List<Cluster>();
            for (int i = 0; i < num_of_clusters; i++)
            {
                Cluster cluster = new Cluster();
                clusterList.Add(cluster);
            }

            //определение кластеров
            double distance_sc;
            int cluster_id;
            int stop = 0;
            while (stop < num_of_clusters)
            {
                stop = 0;
                //удаляем предыдущие объекты кластеров
                foreach (Cluster cluster in clusterList)
                    cluster.c_subjectList.Clear();
                //распределение объектов в кластеры
                for (int i = 0; i < num_of_subject; i++)
                {

                    cluster_id = -1;
                    distance_sc = 1000000000;
                    for (int j = 0; j < num_of_clusters; j++)
                    {
                        if (distance_sc > Math.Sqrt((long)Math.Pow((subjectList[i].green_intensity - clusterList[j].center_green), 2)
                            + (long)Math.Pow((subjectList[i].red_intensity - clusterList[j].center_red), 2) + (long)Math.Pow((subjectList[i].blue_intensity - clusterList[j].center_blue), 2)))
                        {
                            distance_sc = Math.Sqrt((long)Math.Pow((subjectList[i].green_intensity - clusterList[j].center_green), 2)
                            + (long)Math.Pow((subjectList[i].red_intensity - clusterList[j].center_red), 2) + (long)Math.Pow((subjectList[i].blue_intensity - clusterList[j].center_blue), 2));

                            cluster_id = j;
                        }
                    }
                    clusterList[cluster_id].c_subjectList.Add(subjectList[i]); //добавляем объект в список подходящего кластера 
                }

                //определяем новые центроиды в соответствии со средним расстоянием от объектов кластера
                for (int i = 0; i < num_of_clusters; i++)
                {
                    clusterList[i].last_center_green = clusterList[i].center_green;
                    clusterList[i].last_center_red = clusterList[i].center_red;
                    clusterList[i].last_center_blue = clusterList[i].center_blue;

                    clusterList[i].center_green = 0;
                    clusterList[i].center_red = 0;
                    clusterList[i].center_blue = 0;

                    foreach (Subject subject in clusterList[i].c_subjectList)
                    {
                        clusterList[i].center_green += subject.green_intensity;
                        clusterList[i].center_red += subject.red_intensity;
                        clusterList[i].center_blue += subject.blue_intensity;
                    }
                    if (clusterList[i].c_subjectList.Count != 0)
                    {
                        clusterList[i].center_green = clusterList[i].center_green / clusterList[i].c_subjectList.Count;
                        clusterList[i].center_red = clusterList[i].center_red / clusterList[i].c_subjectList.Count;
                        clusterList[i].center_blue = clusterList[i].center_blue / clusterList[i].c_subjectList.Count;
                    }

                    //критерий выхода из цикла (если все цнтроиды совпадают с предыдущим шагом, цикл останавливается)
                    if (clusterList[i].center_green - clusterList[i].last_center_green == 0 && clusterList[i].center_red - clusterList[i].last_center_red == 0 &&
                        clusterList[i].center_blue - clusterList[i].last_center_blue == 0)
                        stop += 1;

                }
            }
        }
    }
}
