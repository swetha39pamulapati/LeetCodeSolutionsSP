using System;
using System.Collections.Generic;
using System.Linq;

namespace _147.SmallestRangeCoveringElements
{
    //https://www.youtube.com/watch?v=zwKGbJEngcw
    class Program
    {
        public int[] SmallestRange(IList<IList<int>> nums)
        {
            var list = new List<Tuple<int, int>>();

            // merge lists
            for (int k = 0; k < nums.Count; k++)
            {
                for (int i = 0; i < nums[k].Count; i++)
                {
                    list.Add(new Tuple<int, int>(nums[k][i], k));
                }
            }

            list = list.OrderBy(i => i.Item1).ToList();

            var (min, max) = (list[0].Item1, list[list.Count - 1].Item1);
            int range = max - min;
            var f = new int[nums.Count];

            var c = 0;
            int left = 0;
            int right = 0;


            // sliding window
            while (right < list.Count)
            {
                if (f[list[right].Item2]++ == 0) c++;

                //contract
                while (c == nums.Count && left < right)
                {
                    if (list[right].Item1 - list[left].Item1 < range)
                    {
                        (min, max) = (list[left].Item1, list[right].Item1);
                        range = max - min;
                    }

                    if (--f[list[left].Item2] == 0) c--;
                    left++;
                }
                right++;
            }

            return new int[2] { min, max };
        }
        static void Main(string[] args)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int[] data = { 4, 10, 15, 24, 26 };
            int[] data1 = { 0, 9, 12, 20 };
            int[] data2 = { 5,18,22,30};
            result.Add(data);
            result.Add(data1);
            result.Add(data2);
            Program p = new Program();
        int[] outpt =     p.SmallestRange(result);
            //  nums = [[4, 10, 15, 24, 26],[0,9,12,20],[5,18,22,30]]
            Console.Write("[");
            Console.Write(outpt[0] + "," + outpt[1]);
            Console.Write("]");
        }
    }
}
