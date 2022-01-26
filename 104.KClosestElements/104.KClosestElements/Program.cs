using System;
using System.Collections.Generic;

namespace _104.KClosestElements
{
    class Program
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int left = 0;
            int right = arr.Length - k;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (x - arr[mid] > arr[mid + k] - x)
                {
                    left = mid + 1;
                }
                else
                    right = mid;
            }
            List<int> result = new List<int>();

            for (int i = left; i < (left + k); i++)
                result.Add(arr[i]);

            return result;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 1, 2, 3, 4, 5 };
            IList<int> result=  p.FindClosestElements(arr, 4, 3);
            foreach(int data in result)
            {
               
                    Console.WriteLine(data + " ");
               
            }
        }
    }
}
