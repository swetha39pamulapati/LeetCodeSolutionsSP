using System;
using System.Collections.Generic;

namespace _50.Combinations
{
    class Program
    {
        public static IList<IList<int>> combinations(int n, int k)
        {

            var result = new List<IList<int>>();
            generateCombinations(1,n,k,new List<int>(), result);
            return result;
        }
        private static void generateCombinations(int start, int n, int k,List<int> list,  List<IList<int>> result)
        {
            if (list.Count == k)
                result.Add(new List<int>(list));
            else
            {
                for(int i = start; i<=n; i++)
                 {
                    list.Add(i);
                    generateCombinations(i + 1, n, k, list, result);
                    list.RemoveAt(list.Count - 1);
                }

            }
        }
            static void Main(string[] args)
        {
            IList<IList<int>> result = combinations(4,2);
            Console.WriteLine(result.Count);
        }
    }
}
