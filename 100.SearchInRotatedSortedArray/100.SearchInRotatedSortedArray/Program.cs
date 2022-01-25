using System;

namespace _100.SearchInRotatedSortedArray
{
    //https://www.youtube.com/watch?v=QdVrY3stDD4&t=400s
    //As the array is rotated, find smallest index 1st using modified binary search
    // and then do regular binary search;
    class Program
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int left = 0;
            int right = nums.Length - 1;
            //Find smallest index;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            int start = left;
            left = 0;
            right = nums.Length - 1;
            if(target>=nums[start] && target <= nums[right])
            {
                left = start;
            }
            else
            {
                right = start;
            }
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                    return mid;
               else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 4,5,6,7,0,1,2 };
            Program p = new Program();
            int result = p.Search(nums,0);
            Console.WriteLine(result);
        }
    }
}
