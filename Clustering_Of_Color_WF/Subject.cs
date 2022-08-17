using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering_Of_Color_WF
{
    class Subject
    {
        public int green_intensity;
        public int red_intensity;
        public int blue_intensity;

        //задаем оттенок (цвет)
        public Subject(int green, int red, int blue)
        {
            green_intensity = green;
            red_intensity = red;
            blue_intensity = blue;
        }
    }
}
