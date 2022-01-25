using System;

namespace _99.PeakElement
{
    class Program
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < nums[mid + 1] )
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
            Program p = new Program();
            int result = p.FindPeakElement(nums);
            Console.WriteLine(result);
        }
    }
}
