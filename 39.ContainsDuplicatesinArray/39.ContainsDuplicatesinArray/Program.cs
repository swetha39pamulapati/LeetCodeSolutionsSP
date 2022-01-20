using System;
using System.Collections.Generic;

namespace _39.ContainsDuplicatesinArray
{
    class Program
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            var data = new HashSet<int>();
            if(nums.Length == 0)
            {
                return null;
            }
          foreach(var n in nums)
            {
                if (!data.Contains(n))
                {
                    data.Add(n);
                }
                else
                {
                    result.Add(n);
                }
            }
                return result;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1 };
            IList<int> result = FindDuplicates(arr);
            if (result.Count > 0) { 
            for(int i = 0; i<result.Count; i++)
            {
                Console.WriteLine(result[i] + " ");
            }
            }
            else
            {
                Console.WriteLine("No duplicates");
            }

        }
    }
}
