using System;
using System.Collections.Generic;

namespace _51.CombinationSum
{
    class Program
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates.Length == 0) return result;
            generateCombinationSum(0,candidates, target, new List<int>(), result);
            return result;
        }

        private static void generateCombinationSum(int start,int[] candidates, int target, IList<int> list, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
            }
            else if (target > 0)
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    list.Add(candidates[i]);
                    generateCombinationSum(i, candidates, target - candidates[i],  list, result);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = {2, 3, 6,7 };

            IList<IList<int>> result = CombinationSum(nums,7);
            Console.WriteLine(result.Count);
        }
    }
}
