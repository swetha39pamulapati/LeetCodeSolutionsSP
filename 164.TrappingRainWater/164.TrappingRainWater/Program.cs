using System;

namespace _164.TrappingRainWater
{
    class Program
    {
        public int Trap(int[] height)
        {
            int result = 0,
                    start = 0;

            while (start < height.Length && height[start] == 0)
                start++;

            for (int i = start; i < height.Length - 1; i++)
            {
                int j = i + 1,
                    highest = 0,
                    highestIndex = -1;

                while (j < height.Length)
                {
                    if (height[j] > highest)
                    {
                        highest = height[j];
                        highestIndex = j;
                    }

                    if (height[j] > height[i])
                        break;

                    j++;
                }

                if (highestIndex - i > 1)
                {
                    int min = Math.Min(height[i], highest);

                    for (int k = i + 1; k < highestIndex; k++)
                        if (height[k] < min)
                            result += min - height[k];
                }

                if (highestIndex != -1)
                    i = highestIndex - 1;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Program p = new Program();
           int res= p.Trap(height);
            Console.WriteLine(res);
        }
    }
}
