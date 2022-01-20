using System;

namespace _20.PeakIndex
{
    class Program
    {
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                    right = mid-1;
            }
            return left;
        }
        static void Main(string[] args)
        {
            int[] data = { 0, 10,15, 5, 2 };
           int result =  PeakIndexInMountainArray(data);
            Console.WriteLine(result);
        }
    }
}
