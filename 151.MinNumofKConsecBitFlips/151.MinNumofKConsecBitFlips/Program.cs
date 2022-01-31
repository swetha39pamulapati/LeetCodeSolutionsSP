using System;
using System.Collections.Generic;
using System.Linq;

namespace _151.MinNumofKConsecBitFlips
{
    class Program
    {
        public int MinKBitFlips(int[] nums, int k)
        {
            int result = 0;
            var queue = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (queue.Any() && queue.Peek() <= i)
                    queue.Dequeue();

                if ((nums[i] + queue.Count) % 2 == 0)
                {
                    result++;
                    if (i + k > nums.Length) 
                        return -1;
                    queue.Enqueue(i + k);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 0, 1, 0, 1, 1, 0 };
            Program p = new Program();
         int result =   p.MinKBitFlips(nums, 3);
            Console.WriteLine(result);
        }
    }
}
