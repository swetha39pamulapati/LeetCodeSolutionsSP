using System;

namespace _42.RotateMatrix
{
    class Program
    {
        public static void Rotate(int[][] matrix)
        {
            for(int i = 0; i<matrix.Length; i++)
            {
                for (int j = i; j < matrix[i].Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                        }
            }
            for(int k = 0; k<matrix.Length; k++)
            {
                int start = 0;
                int end = matrix[k].Length - 1;
                while (start < end)
                {
                    int temp = matrix[k][start];
                    matrix[k][start] = matrix[k][end];
                    matrix[k][end] = temp;
                    start++;
                    end--;
                }

            }
        }
        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][]
            {
                new int[]{ 1, 2, 3 },
                 new int[]{ 4,5,6},
                  new int[]{ 7,8,9},


            };
            PrintMatrix(matrix);
            Console.WriteLine("Rotated Matrix is : ");
            Rotate(matrix);
            PrintMatrix(matrix);
        }
    }
}
