using System;

namespace _102.SearchIn2DMatrix
{
    class Program
    {
        //https://www.youtube.com/watch?v=eT0UqrYuqbg
        //conside matrix as 1D
        public bool SearchIn2DMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            int colums = matrix[0].Length;
            int left = 0;
            int right = rows * colums - 1;
            while(left<= right)
            {
                int mid = left + (right - left) / 2;
                int midPointElement = matrix[mid/colums][mid%colums];//To get ll =>matrix[1][1] we divide(rows) and modulus(columns) by columns;
                if (midPointElement == target)
                    return true;
                if (midPointElement < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return false;
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
                new int[]{ 1,3,5,7 },
                 new int[]{ 10,11,16,20},
                  new int[]{ 23,30,35,39},


            };
            Program p = new Program();
            PrintMatrix(matrix);
            Console.WriteLine("Rotated Matrix is : ");
          bool data =   p.SearchIn2DMatrix(matrix,3);
            Console.WriteLine(data);
        }
    }
}
