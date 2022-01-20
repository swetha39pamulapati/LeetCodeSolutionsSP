using System;
using System.Collections.Generic;

namespace _48.Permutations
{
    class Program
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> permutes = new List<IList<int>>();
            generatePermutations(new List<int>(),nums, permutes);
            return permutes;
        }
        private static void generatePermutations(List<int> list, int[] nums, List<IList<int>> permutes)
        {
            List<int> tempList = null;
            if(list.Count!= nums.Length)
            {
                for(int i = 0; i<nums.Length; i++)
                {
                    if (!list.Contains(nums[i]))
                    {
                        tempList = new List<int>(list);
                        tempList.Add(nums[i]);
                        generatePermutations(tempList, nums,permutes);
                    }
                    
                }
            }

            else
            {
                permutes.Add(list);
            }

        }
            static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>>  result = Permute(nums);
            Console.WriteLine(result.Count);
        }
    }
}
