using System;

namespace _105.MinimumSubArray
{
    //https://www.youtube.com/watch?v=jKF9AcyBZ6E
    class Program
    {
        public int minSubArray(int s, int[] nums)
        {
            int result = int.MaxValue;
            int left = 0;
            int val_sum = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                val_sum += nums[i];
                while (val_sum >= s)
                {
                    result = Math.Min(result, i + 1 - left);
                    val_sum -= nums[left];
                    left++;
                }
            }
            return result != int.MaxValue ? result : 0;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
          int  target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };
          int result =  p.minSubArray(target,nums);
            Console.WriteLine(result);
        }
    }
}
