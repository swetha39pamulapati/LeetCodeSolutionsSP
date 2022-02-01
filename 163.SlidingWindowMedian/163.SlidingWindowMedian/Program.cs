using System;
using System.Collections.Generic;

namespace _163.SlidingWindowMedian
{
    class Program
    {
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            List<double> list = new List<double>();
            double[] ret = new double[nums.Length - k + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                int l = 0, r = list.Count;
                while (l < r)
                {
                    int m = l + (r - l) / 2;
                    if (nums[i] > list[m])
                        l = m + 1;
                    else
                        r = m;
                }
                list.Insert(l, nums[i]);
                if (list.Count > k)
                    list.Remove(nums[i - k]);
                if (i - k + 1 >= 0)
                {
                    if (k % 2 == 0)
                    {
                        ret[i - k + 1] = (list[k / 2] + list[k / 2 - 1]) / 2;
                    }
                    else
                        ret[i - k + 1] = list[k / 2];
                }
            }
            return ret;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            Program p = new Program();
            double[] data = p.MedianSlidingWindow(nums, k);
            Console.WriteLine(data.Length);
        }
    }
}
