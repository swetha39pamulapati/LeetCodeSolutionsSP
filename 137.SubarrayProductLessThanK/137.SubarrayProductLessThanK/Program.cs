using System;

namespace _137.SubarrayProductLessThanK
{
    class Program
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;
            int prod = 1;
            int result = 0;
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                prod *= nums[right];
                while (prod >= k)
                {
                    prod /= nums[left];
                    left++;

                }
                result += right - left + 1;
                right++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 10, 5, 2, 6 };
            int k = 100;
            Program p = new Program();
           int result = p.NumSubarrayProductLessThanK(nums, k);
            Console.WriteLine(result);
        }
    }
}
