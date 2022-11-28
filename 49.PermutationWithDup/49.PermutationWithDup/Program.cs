using System;
using System.Collections.Generic;

namespace _49.PermutationWithDup
{
    class Program
    {
        public static IList<IList<int>> PermuteWithDup(int[] nums)
        {
            var n = nums.Length;

            var result = new List<IList<int>>();
            if (n == 0) return result;

            Array.Sort(nums);

            generatePermutations(new List<int>(), nums, new bool[n],   result);

            return result;
        }
        private static void generatePermutations(List<int> list, int[] nums, bool[] isVisited, List<IList<int>> permutes)
        {
            if (list.Count != nums.Length)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (isVisited[i]) 
                        continue;
                    if (i > 0 && nums[i - 1] == nums[i] && isVisited[i - 1]) 
                        continue;
                    isVisited[i] = true;
                   list.Add(nums[i]);
                    generatePermutations(list, nums, isVisited, permutes);
                    isVisited[i] = false;
                    list.RemoveAt(list.Count - 1);
                }
            }

            else
            {
                permutes.Add(new List<int>(list));
            }
        }
            static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            IList<IList<int>> result = PermuteWithDup(nums);
            Console.WriteLine(result.Count);
        }
    }
}
