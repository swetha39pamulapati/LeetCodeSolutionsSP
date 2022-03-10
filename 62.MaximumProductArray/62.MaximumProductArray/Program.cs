using System;

namespace _62.MaximumProductArray
{
    class Program
    {

        public int MaxProduct(int[] nums)
        {

            int max = nums[0];
            int min = nums[0];
            int ans = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    int temp = max;
                    max = min;
                    min = temp;
                }
                max = Math.Max(nums[i], max * nums[i]);
                min = Math.Min(nums[i], min * nums[i]);
                ans = Math.Max(ans, max);
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 2,3,-2,4};
         int result=   p.MaxProduct(arr);
            Console.WriteLine(result);
        }
    }
}
