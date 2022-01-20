using System;

namespace _40.SetMatrixZeros
{
    class Program
    {
        public static void SetZeroes(int[][] matrix)
        {
            bool[] row = new bool[ matrix.Length];
            bool[] column = new bool[matrix[0].Length];
           for(int r = 0; r< matrix.Length; r++)
            {
                for(int c = 0; c< matrix[0].Length; c++)
                {
                    if (matrix[r][c] == 0)
                        row[r] = true;
                    column[c] = true;
                }
            }
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    //if(row[r]&& column[c]) { 
                    if((row[r] && column[c]) || (row[c]&& column[r]))
                    {
                        matrix[r][c] = 0;
                    }
                    //}
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
                new int[]{ 1, 1, 1 },
                 new int[]{ 1,0,1 },
                  new int[]{ 1,1,1 },


                 // new int[]{ 0,1,2,0 },
                 //new int[]{ 3,4,5,2 },
                 // new int[]{ 1,3,1,5},
            };
            PrintMatrix(matrix);
            SetZeroes(matrix);
            Console.WriteLine("zero matrix is :" +"\n");
            PrintMatrix(matrix);
            
        }
    }
}
