using System;

namespace _111.KclosestToOrigin
{
    class Program
    {
        public int[][] KClosest(int[][] points, int K)
        {
            if (points == null || points.Length == 0)
                return points;

            int left = 0, right = points.Length - 1;

            while (left < right)
            {
                int pivotLoc = Partition(points, left, right);

                if (pivotLoc == K)
                    break;
                else if (pivotLoc > K)
                    right = pivotLoc - 1;
                else
                    left = pivotLoc + 1;
            }

            int[][] res = new int[K][];
            Array.Copy(points, res, K);
            return res;
        }

        private int Partition(int[][] points, int left, int right)
        {
            int pivot = GetDistance(points[right]);
            int pivotLoc = left;

            for (int i = left; i < right; i++)
            {
                if (GetDistance(points[i]) <= pivot)
                {
                    Swap(points, i, pivotLoc);
                    pivotLoc++;
                }
            }

            Swap(points, pivotLoc, right);
            return pivotLoc;
        }

        private int GetDistance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }

        private void Swap(int[][] points, int i, int j)
        {
            var tmp = points[i];
            points[i] = points[j];
            points[j] = tmp;
        }
        private static int Distance(int[] p) => p[0] * p[0] + p[1] * p[1];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
