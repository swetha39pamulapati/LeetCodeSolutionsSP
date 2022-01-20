using System;
using System.Collections.Generic;

namespace _3.DisappearedInArray
{
    class Program
    {
        public static IList<int> disappearedInArray(int[] arr)
        {

            int n = arr.Length;
            var numbers = new HashSet<int>();
            List<int> missingNumbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                    numbers.Add(arr[i]);
            }

            for (int j = 1; j < n+1; j++)
            {
                if (!numbers.Contains(j))
                    missingNumbers.Add(j);

            }
            return missingNumbers;
            //var list = new bool[nums.Length];
            //foreach (var n in nums)
            //{
            //    list[n - 1] = true;
            //}
            //var res = new List<int>();
            //for (var i = 0; i < list.Length; i++)
            //{
            //    if (!list[i]) 
            //        res.Add(i + 1);
            //}
            //return res;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,1 };
         IList<int> data =   disappearedInArray(arr);
            foreach(var i in data)
            Console.WriteLine(i);
        }
    }
}
