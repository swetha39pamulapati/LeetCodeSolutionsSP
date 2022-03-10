using System;
using System.Collections.Generic;

namespace _52.CombinationSumii
{
    class Program
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (candidates.Length == 0) return result;
            Array.Sort(candidates);
            generateSum(0, new List<int>(), candidates, target,result);
            return result;
        }
        private static void generateSum(int start, List<int> list, int[] candidates, int target,List<IList<int>> result)
        {
            
            if (target == 0)
                result.Add(new List<int>(list));
            else
            {
                for(int i = start; i<candidates.Length; i++)
                {
                    if (i > start && candidates[i] == candidates[i - 1])
                        continue;
                    //Time limit exceed so added this condition
                    if (target - candidates[i] < 0)
                        continue;
                    list.Add(candidates[i]);
                    generateSum(i + 1, list, candidates, target - candidates[i], result);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
            static void Main(string[] args)
        {
            int[] nums = { 10, 1, 2, 7, 6, 1, 5 };
            IList<IList<int>> result = CombinationSum2(nums, 8);
            Console.WriteLine(result.Count);
        }
    }
}
