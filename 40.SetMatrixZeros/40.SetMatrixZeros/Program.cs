using System;

namespace _40.SetMatrixZeros
{
    class Program
    {
        public static void SetZeroes(int[][] matrix)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix[0].GetLength(0);

            bool[] markedRows = new bool[rows];
            bool[] markedCols = new bool[cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        markedRows[i] = true;
                        markedCols[j] = true;
                    }
                }
            }

            for (int i = 0; i < markedRows.Length; i++)
            {
                if (markedRows[i])
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            for (int i = 0; i < markedCols.Length; i++)
            {
                if (markedCols[i])
                {
                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j][i] = 0;
                    }
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
