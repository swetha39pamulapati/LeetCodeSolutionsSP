using System;

namespace _93.Non_overlappingIntervals
{
    //https://www.youtube.com/watch?v=nONCGxWoUfM
    class Program
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0) return 0;
            Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
            int result = 0;
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
                if (intervals[i][0] >= end)
                    end = intervals[i][1];
                else
                    result++;
            return result;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]
              {
                new int[]{ 1,  2 },
                 new int[]{ 2,3},
                  new int[]{ 3,4},
                  new int[]{ 1,3},

              };
            Program p = new Program();
            int result = p.EraseOverlapIntervals(matrix);
            Console.WriteLine(result);
        }
    }
}
