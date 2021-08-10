//KMeans.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI
{
    public class KMeans
    {
        //tham so la tap hop cac diem va so cum pham chia
        public static List<PointCollection> DoKMeans(PointCollection points, int clusterCount)
        {
            //phan chia cac points vao cac cum
            List<PointCollection> allClusters = new List<PointCollection>();
            List<List<Point>> allGroups = ListUtility.SplitList<Point>(points, clusterCount);
            foreach (List<Point> group in allGroups)
            {
                PointCollection cluster = new PointCollection();
                cluster.AddRange(group);
                allClusters.Add(cluster);
            }

            //bat dau gom cum k-mean
            int movements = 1;
            while (movements > 0)
            {
                movements = 0;

                foreach (PointCollection cluster in allClusters) //duyet tungf cum trong tat ca cac nhom cum duoc phan
                {
                    //3 cluster
                    for (int pointIndex = 0; pointIndex < cluster.Count; pointIndex++) 
                        //sau do duyet tung diem trong tung nhom cum
                    {
                        Point point = cluster[pointIndex];
                        // lay ra 1 point
                        int nearestCluster = FindNearestCluster(allClusters, point);
                        //tim ra cum neighboor gan nhat so voi point do
                        if (nearestCluster != allClusters.IndexOf(cluster)) 
                            //neu nhu point can phai move
                        {
                            if (cluster.Count > 1) //cluster shall have minimum one point
                            {
                                Point removedPoint = cluster.RemovePoint(point);
                                allClusters[nearestCluster].AddPoint(removedPoint);
                                movements += 1;
                            }
                        }
                    }
                }
            }

            return (allClusters);
        }

        public static int FindNearestCluster(List<PointCollection> allClusters, Point point)
        {
            double minimumDistance = 0.0;
            int nearestClusterIndex = -1;

            for (int k = 0; k < allClusters.Count; k++) //find nearest cluster
            {
                double distance = Point.FindDistance(point, allClusters[k].Centroid);
                if (k == 0)
                {
                    minimumDistance = distance;
                    nearestClusterIndex = 0;
                }
                else if (minimumDistance > distance)
                {
                    minimumDistance = distance;
                    nearestClusterIndex = k;
                }
            }

            return (nearestClusterIndex);
        }
    }
}
