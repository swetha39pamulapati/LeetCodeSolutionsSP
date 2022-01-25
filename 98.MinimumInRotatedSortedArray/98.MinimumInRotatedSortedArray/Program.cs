using System;

namespace _98.MinimumInRotatedSortedArray
{
    //https://www.youtube.com/watch?v=IzHR_U8Ly6c
    class Program
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
                return -1;
            if (nums.Length == 1)
                return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mid>0 && nums[mid] < nums[mid - 1])
                    return nums[mid];
                else if(nums[left] <= nums[mid] && nums[mid]> nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return nums[left];
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 4, 5, 1, 2 };
            Program p = new Program();
            int result = p.FindMin(nums);
            Console.WriteLine(result);
        }
    }
}
