using System;
using System.Collections.Generic;

namespace _97.InsertIntervals
{
    //https://www.youtube.com/watch?v=K7B9ZTKoRpQ
    class Program
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            int i = 0;

            // Step 1 - add all intervals ending before newInterval starts
            while (i < intervals.Length && intervals[i][1] < newInterval[0])
                result.Add(intervals[i++]);

            // Step 2 - update the newInterval by merging with all overlapping intervals
            while (i < intervals.Length && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            result.Add(newInterval); // add updated interval

            // Step 3 - add remaining intervals
            while (i < intervals.Length)
                result.Add(intervals[i++]);

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[2][]
              {
                new int[]{ 1,3 },
                 new int[]{ 6,9},
                  

              };
            int[] data = {2,5 };
            Program p = new Program();
            int[][] result = p.Insert(matrix,data);
            Console.WriteLine(result.Length);
        }
    }
}
