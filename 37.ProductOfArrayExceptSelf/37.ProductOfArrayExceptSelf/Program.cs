using System;

namespace _37.ProductOfArrayExceptSelf
{
    class Program
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            int[] result = new int[nums.Length];
            //int r = nums.Length-1;
            int temp = 1;
           
            for (int i = 0; i<nums.Length; i++)
            {

                result[i] = temp;
                temp = temp * nums[i];
            }
            temp = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = {  2, 3, 4 };
            int[] result = ProductExceptSelf(arr);
            for(int i = 0; i<result.Length; i++)
            {
                Console.WriteLine(result[i] + " ");
            }
          
        }
    }
}
