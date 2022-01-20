using System;

namespace _9.CountingBits
{
    class Program
    {
        // This kind of pattern related issue must be able to solve by DP, and the key is to
        // form a formula for our DP solution. The ideas are:
        // 1) if value = 0 then number of 1's == 0
        // 2) if value is odd then number of 1's equals previous even value's number of 1's + 1
        // 3) if value is even then number of 1's equals value/2 's number of 1's
        public static int[] CountBits(int num)
        {
            int[] arr = new int[num + 1];
            arr[0] = 0;
            for(int i =1; i<=num; i++)
            {
                if (i % 2 == 1)
                {
                    arr[i] = arr[i - 1] + 1;
                }
                else
                {
                    arr[i] = arr[i / 2];
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
          int [] data =   CountBits(2);
            foreach (int i in data)
                Console.Write(i + " ");
        }
    }
}
