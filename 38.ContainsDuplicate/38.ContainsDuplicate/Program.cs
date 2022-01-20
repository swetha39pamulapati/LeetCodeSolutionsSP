using System;
using System.Collections.Generic;

namespace _38.ContainsDuplicate
{
    class Program
    {
        public static int FindDuplicate(int[] nums)
        {
            var data = new HashSet<int>();
            foreach (var n in nums) {
                if (!data.Contains(n))
                {
                    data.Add(n);
                }
                else
                {
                    return n;
                }
                    }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = {1, 3, 4, 4, 2};
            Console.WriteLine(FindDuplicate(nums));
        }
    }
}
