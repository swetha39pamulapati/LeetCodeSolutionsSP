using System;

namespace _101.SearchInRotatedArray2
{
    class Program
    {
        public bool Search(int[] nums, int target) {
       int left = 0, right = nums.Length - 1;
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(nums[mid] == target)
                return true;
            
            if(nums[left] == nums[mid] && nums[mid] == nums[right])
            {
                left++;
                right--;
            }
            else if(nums[left] <= nums[mid]) //case when duplicates occur
            {               
                if(nums[left] <= target && target <= nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else //when right part is sorted
            {
                if(nums[right] >= target && target >= nums[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        
        return false;        
    }
            static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            Program p = new Program();
            bool result = p.Search(nums, 0);
            Console.WriteLine(result);
        }
    }
}
