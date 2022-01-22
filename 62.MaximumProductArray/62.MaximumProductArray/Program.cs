using System;

namespace _62.MaximumProductArray
{
    class Program
    {

        public int MaxProduct(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            int min = nums[0], max = nums[0], res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int product1 = nums[i] * min;
                int product2 = nums[i] * max;
                int product3 = nums[i];

                res = Math.Max(res, Math.Max(Math.Max(product1, product2), product3));

                max = Math.Max(Math.Max(product1, product2), product3);
                min = Math.Min(Math.Min(product1, product2), product3);
            }

            return res;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 0,2 };
         int result=   p.MaxProduct(arr);
            Console.WriteLine(result);
        }
    }
}
