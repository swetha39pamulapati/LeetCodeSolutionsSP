using System;

namespace _18.BinarySearch
{
    class Program
    {
        public static int binarySearch(int[] arr, int value)
        {
            int n = arr.Length;
            int l = 0; int r = n - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == value)
                    return mid;
                else if (arr[mid] < value)
                    l = mid + 1;
                else r = mid - 1;
                   
            }
            return -1;
            
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 3, 5, 9, 12 };
           Console.WriteLine("The data is found at :" +binarySearch(arr, 11));
        }
    }
}
