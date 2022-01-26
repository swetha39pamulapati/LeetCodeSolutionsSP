using System;

namespace _103.Searchin2DMatrix2
{
    class Program
    {
        //https://www.youtube.com/watch?v=dcTJRw1704w
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int left = 0;
            int right = rows - 1;
            while (right >= 0 && left < cols)
            {
                if (matrix[right][left] > target)
                    right--;
                else if (matrix[right][left] < target)
                    left++;
                else
                    return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][]
           {
                new int[]{ 1,4,7,11 },
                 new int[]{ 10,13,14,17},
                  new int[]{ 18,21,25,30},


           };
            Program p = new Program();
            bool data = p.SearchMatrix(matrix, 3);
            Console.WriteLine(data);
        }
    }
}
