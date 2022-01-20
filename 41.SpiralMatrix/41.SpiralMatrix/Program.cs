using System;
using System.Collections.Generic;

namespace _41.SpiralMatrix
{
    class Program
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0)
            {
                return result;
            }
            int direction = 0;
            int top = 0, down = matrix.Length - 1, left = 0, right = matrix[0].Length - 1;
            while(top<=down && left<= right)
            {
                if(direction == 0)
                {
                    for(int i = left; i<= right; i++)
                    {
                        result.Add(matrix[top][i]);
                    }
                    top += 1;
                }
                else if(direction == 1)
                {
                    for (int i = top; i <= down; i++)
                    {
                        result.Add(matrix[i][right]);
                    }
                    right -= 1;
                }
                else if (direction == 2)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[down][i]);
                    }
                    down -= 1;
                }
                else if (direction == 3)
                {
                    for (int i = down; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }
                    left += 1;
                }
                direction = (direction + 1) % 4;
            }
            return result;
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
                 new int[]{ 4,5,6 },
                  new int[]{ 7,8,9 },


            };
            PrintMatrix(matrix);
            Console.WriteLine("The spiral matrix is :" + "\n");
            IList<int> result=  SpiralOrder(matrix);
            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; i++)
                    Console.Write(result[i] + ", ");
            }
            

        }
    }
}
