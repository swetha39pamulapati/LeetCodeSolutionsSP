using System;
using System.Collections.Generic;

namespace _46.Subsets
{
    class Program
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return subsets;
            generateSubsets(0, nums, new List<int>(), subsets);
            return subsets;
        }
        private static void generateSubsets(int start, int[] nums, List<int> list, List<IList<int>> subsets)
        {
            subsets.Add(new List<int>(list));
            for (int i = start; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                generateSubsets(i + 1, nums, list, subsets);
                list.RemoveAt(list.Count - 1);
            }
            }
            static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            IList<IList<int>> result =  Subsets(arr);
           
            Console.WriteLine(result.Count);
        }
    }
}
