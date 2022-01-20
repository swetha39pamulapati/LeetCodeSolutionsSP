using System;

namespace _32.SquareArray
{
    class Program
    {
        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int l = 0;
            int r = nums.Length - 1;
            for(int i = 0; i<nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            for(int i =nums.Length-1; i>=0; i--)
            {
                if (nums[l] > nums[r])
                {
                    result[i] = nums[l];
                        l++;

                }
                else
                {
                    result[i] = nums[r];
                    r--;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] data = { -4, -1, 0, 3, 10};
         int[] result =    SortedSquares(data);
            for(int  i =0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
