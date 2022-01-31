using System;
using System.Collections.Generic;
using System.Linq;

namespace _150.SlidingWindowMax
{
    //https://www.youtube.com/watch?v=LiSdD3ljCIE
    class Program
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var ret = new List<int>();
            var list = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                while (list.Any() && nums[list.First.Value] <= nums[i])
                    list.RemoveFirst();

                list.AddFirst(i);

                if (list.Any() && list.Last.Value < i - k + 1)
                    list.RemoveLast();

                if (i + 1 >= k)
                    ret.Add(nums[list.Last.Value]);
            }
            return ret.ToArray();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
           int[] result =  p.MaxSlidingWindow(nums,k);
            Console.WriteLine(result);
        }
    }
}
