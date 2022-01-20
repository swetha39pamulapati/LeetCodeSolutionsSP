using System;
using System.Collections.Generic;

namespace _47.SubsetWithDup
{
    class Program
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> subsets = new List<IList<int>>();
                Array.Sort(nums);
            generateSubsets(0, nums, new List<int>(), subsets);
            return subsets;
        }
        private static void generateSubsets(int start, int[] nums, List<int> list, List<IList<int>> subsets)
        {
            subsets.Add(new List<int>(list));
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i - 1] == nums[i]) 
                    continue;
                list.Add(nums[i]);
                generateSubsets(i + 1, nums, list, subsets);
                list.RemoveAt(list.Count - 1);
            }
        }
            static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2 };
            IList<IList<int>> result = SubsetsWithDup(arr);

            Console.WriteLine(result.Count);
        }
    }
}
