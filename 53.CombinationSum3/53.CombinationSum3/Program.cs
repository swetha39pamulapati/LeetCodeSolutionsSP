using System;
using System.Collections.Generic;

namespace _53.CombinationSum3
{
    class Program
    {
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> result = new List<IList<int>>();
            generateCombination(1, k, n,new List<int>(), result);
            return result;
        }
        private static void generateCombination(int start, int k, int n,List<int>list, List<IList<int>> result)
        {
            if (n < 0) return;
            if (k == 0)
            {
                if (n == 0)
                    result.Add(new List<int>(list));
            }
            else
            {
                for (int i = start; i <= 9; i++)
                {
                    list.Add(i);
                    generateCombination(i + 1, k - 1, n - i, list, result);
                    list.RemoveAt(list.Count - 1);
                }
            }

        }
        static void Main(string[] args)
        {
            IList<IList<int>> result = CombinationSum3(3,9);
            Console.WriteLine(result.Count);
        }
    }
}
