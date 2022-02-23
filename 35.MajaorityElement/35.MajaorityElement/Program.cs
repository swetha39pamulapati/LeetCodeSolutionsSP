using System;
using System.Collections.Generic;

namespace _35.MajaorityElement
{
    class Program
    {
        public static int MajorityElement(int[] nums)
        {
            int result = 0;
            int n = nums.Length;
            int mid = n / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var k in nums)
            {
                if (!dict.ContainsKey(k))
                    dict.Add(k, 0);
                dict[k] += 1;
                if (dict[k] > mid)
                {
                    return k;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 6, 1, 1, 2 };
            Console.WriteLine(MajorityElement(nums));
        }
    }
}
