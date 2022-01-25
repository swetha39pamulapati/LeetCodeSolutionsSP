using System;

namespace _96.BurstBalloons
{
    //https://www.youtube.com/watch?v=c_5n_qdDRDo
    class Program
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points == null || points.Length == 0)
                return 0;

            Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
            int end = points[0][1], cnt = 1;
            for (int i = 1; i < points.Length; i++)
            {
                if (end >= points[i][0])
                    continue;

                cnt++;
                end = points[i][1];
            }

            return cnt;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]
              {
                new int[]{ 10,16 },
                 new int[]{ 2,8},
                  new int[]{ 1,6},
                  new int[]{ 7,12},

              };
            Program p = new Program();
            int result = p.FindMinArrowShots(matrix);
            Console.WriteLine(result);
        }
    }
}
