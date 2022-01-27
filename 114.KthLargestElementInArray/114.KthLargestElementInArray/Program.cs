using System;

namespace _114.KthLargestElementInArray
{
    class Program
    {
        public int FindKthLargest(int[] nums, int k)
        {

            return QS(nums, 0, nums.Length - 1, nums.Length - k);
        }

        public int QS(int[] nums, int start, int end, int index)
        {
            int pivot = nums[end];
            int left = start;
            int right = end - 1;

            do
            {
                while (left <= end && nums[left] < pivot)
                {
                    left++;
                }
                while (right > start && nums[right] >= pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = nums[right];
                    nums[right] = nums[left];
                    nums[left] = temp;
                }
            }
            while (left < right);

            nums[end] = nums[left];
            nums[left] = pivot;

            if (left == index) return nums[left];
            else if (left < index) return QS(nums, left + 1, end, index);
            else return QS(nums, start, left - 1, index);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 3, 2, 1, 5, 6, 4 };
           int result =  p.FindKthLargest(nums, 2);
            Console.WriteLine(result);
        }
    }
}
