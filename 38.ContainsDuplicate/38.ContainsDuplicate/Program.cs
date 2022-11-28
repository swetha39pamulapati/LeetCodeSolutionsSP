using System;
using System.Collections.Generic;

namespace _38.ContainsDuplicate
{
    class Program
    {
        //public static int FindDuplicate(int[] nums)
        //{
        //    var data = new HashSet<int>();
        //    foreach (var n in nums) {
        //        if (!data.Contains(n))
        //        {
        //            data.Add(n);
        //        }
        //        else
        //        {
        //            return n;
        //        }
        //            }
        //    return -1;
        //}
        public static int FindDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int n = nums.Length - 1; // numbers in [1, n]

            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int cnt = 0;
                foreach (var num in nums)
                {
                    if (num <= mid)
                    {
                        cnt++;
                    }
                }
                if (cnt <= mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return right;
        }
        static void Main(string[] args)
        {
            int[] nums = {1, 3, 4, 4, 2};
            Console.WriteLine(FindDuplicate(nums));
        }
    }
}
