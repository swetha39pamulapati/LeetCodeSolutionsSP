using System;

namespace _2.MissingNumber
{
    class Program
    {
        public static int missingNumber(int[] arr)
        {
            int n = arr.Length;
            int sum = 0;
            int sumN = n * (n + 1) / 2;
            for(int i = 0; i<n; i++)
            {
                sum += arr[i];
            }
            return sumN - sum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 4, 5, 6 };
           int data = missingNumber(arr);
            Console.WriteLine(data);
        }
    }
}
