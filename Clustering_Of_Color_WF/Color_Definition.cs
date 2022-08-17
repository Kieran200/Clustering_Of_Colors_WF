using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering_Of_Color_WF
{
    class Color_Definition
    {
        double distance_sc;
        public void Color_Def(int red, int green, int blue, List<Cluster> clusterList, out int cluster_id)
        {
            cluster_id = -1;
            distance_sc = 1000000000;
            for (int j = 0; j < clusterList.Count; j++)
                {
                    if (distance_sc > Math.Sqrt((long)Math.Pow((green - clusterList[j].center_green), 2)
                        + (long)Math.Pow((red - clusterList[j].center_red), 2) + (long)Math.Pow((blue - clusterList[j].center_blue), 2)))
                    {
                        distance_sc = Math.Sqrt((long)Math.Pow((green - clusterList[j].center_green), 2)
                        + (long)Math.Pow((red - clusterList[j].center_red), 2) + (long)Math.Pow((blue - clusterList[j].center_blue), 2));

                        cluster_id = j;
                    }
                }
                
        }

    }
}
