using System;
using System.Collections.Generic;

namespace _91.MergeIntervals
{
    class Program
    {
        //https://www.youtube.com/watch?v=qKczfGUrFY4
        public int[][] Merge(int[][] intervals)
        {

            if (intervals.Length < 2) return intervals;

            //sort the intervals first, based each interval's first entries
            Array.Sort(intervals, (arr1, arr2) => arr1[0].CompareTo(arr2[0]));
            //O(nlog(n))

            //Create Array to Store result
            var result = new List<int[]>();

            //store first interval
            int start_current = intervals[0][0];
            int end_current = intervals[0][1];

            //iterate through the intervals starting from second item
            //O(n)
            for (int i = 1; i < intervals.Length; i++)
            {

                //[1,3]            [2,5]
                //  3    >            2
                // overlapping ; change the end to 5
                //repeat tille all continuous overlaps
                if (intervals[i][0] <= end_current)
                {
                    end_current = Math.Max(end_current, intervals[i][1]);

                    continue;
                }
                //add the result once next non-overlapping reached
                result.Add(new[] { start_current, end_current });

                //reset the start and end current values to the current non-overlapping item
                start_current = intervals[i][0];
                end_current = Math.Max(end_current, intervals[i][1]);
            }

            //Add last item
            result.Add(new[] { start_current, end_current });

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]
            {
                new int[]{ 1,  3 },
                 new int[]{ 2,6},
                  new int[]{ 8,10},
                  new int[]{ 15,18},

            };
            Program p = new Program();
            int[][] result = p.Merge(matrix);
            Console.WriteLine(result.Length);
        }
    }
}
