using System;

namespace _36.Convert1Dto2D
{
    class Program
    {
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            int[][] result = new int[m][];
            int len = original.Length;
            if (len != m * n)
                return new int[0][];

            int index = 0;
            int i = 0;
            while (i < m)
            {
                int j = 0;
                result[i] = new int[n];
                while (j < n)
                {
                    result[i][j++] = original[index++];
                }

                i++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] original = { 1, 2, 3, 4 };
            int m = 2;
            int n = 2;
            int [][] result = Construct2DArray(original, m, n);
            for(int i = 0; i<result.Length; i++)
            {
                for(int j = 0; j< result.Length; j++)
                {
                    Console.Write(result[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
