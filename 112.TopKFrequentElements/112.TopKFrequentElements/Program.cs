using System;
using System.Collections.Generic;
using System.Linq;

namespace _112.TopKFrequentElements
{
    class Program
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0)
                return new int[] { };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 0);

                dict[item] += 1;
            }

            return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList<int>().ToArray();
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            Program p = new Program();
         int[] result =   p.TopKFrequent(nums, k);
            Console.WriteLine(result.Length);
        }
    }
}
