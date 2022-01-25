using System;
using System.Collections.Generic;

namespace _92.IntervalListIntersection
    //https://www.youtube.com/watch?v=Qh8ZjL1RpLI
{
    //1stList : [[0,2],[5,10],[13,23],[24,25] ]
    //2ndList : [[1,5],[8,12],[15,24],[25,26]]
    //1st condition. [0,2][1,5]
    //The start value of 2nd list should be less than end value of 1st list and
    //The end val of 2nd list should be greater than  start value of 1ss list 
    //(max(1ststart,2nd start), min(1st end, 2nd end) ==>[1,2];
    //Now increase 1stList Pointer as it is less(2) than 2ndList Pointer(5);
    //[5,10][1,5]=>[5,5],(5 is lesss than 10 so increase 2ndpointer

    class Program
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            if (firstList == null || secondList == null)
                return new int[0][];

            List<int[]> res = new List<int[]>();
            int idx1 = 0, idx2 = 0;
            while (idx1 < firstList.Length && idx2 < secondList.Length)
            {
                int start1 = firstList[idx1][0];
                int end1 = firstList[idx1][1];

                int start2 = secondList[idx2][0];
                int end2 = secondList[idx2][1];

                if (start1 <= end2 && start2 <= end1)
                {
                    int start = Math.Max(start1, start2);
                    int end = Math.Min(end1, end2);
                    res.Add(new int[] { start, end });
                }

                if (end1 <= end2)
                    idx1++;
                else
                    idx2++;
            }

            return res.ToArray();
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]
             {
                new int[]{0,2 },
                 new int[]{ 5,10},
                  new int[]{ 13,23},
                  new int[]{ 24,25},

             };
            int[][] matrix1 = new int[4][]
            {
                new int[]{1,5 },
                 new int[]{ 8,12},
                  new int[]{ 15,24},
                  new int[]{ 25,26},

            };
            Program p = new Program();
            int[][] result = p.IntervalIntersection(matrix,matrix1);
            Console.WriteLine(result.Length);
        }
    }
}
