using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SingleNumberInArray
{
    class Program
    {
        public static int singleNumber(int[] arr)
        {
            int n = arr.Length;
            var data = new HashSet<int>();
            foreach(var i in arr)
            {
                if (data.Contains(arr[i]))
                {
                    data.Remove(arr[i]);
                }
                else
                {
                    data.Add(arr[i]);
                }
            }
            return data.First();
        }
        static void Main(string[] args)
        {
            int[] arr = { 4,1,2,1,2 };
          int result =   singleNumber(arr);
            Console.WriteLine(result);
        }
    }
}
