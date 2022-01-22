using System;

namespace _69.JumpGame
{
    class Program
    {
        public bool CanJump(int[] nums)
        {
            int maxLength = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0 && maxLength == 0)
                {
                    return false;
                }
                if (nums[i] >= maxLength)
                {
                    maxLength = nums[i];
                }
                maxLength--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            Program p = new Program();
            bool data = p.CanJump(nums);
            Console.WriteLine(data);
        }
    }
}
