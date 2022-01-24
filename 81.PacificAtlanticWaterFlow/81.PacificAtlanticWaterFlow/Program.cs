using System;
using System.Collections.Generic;

namespace _81.PacificAtlanticWaterFlow
{
    //https://www.youtube.com/watch?v=s-VkcjHqkGI
    class Program
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {

            List<IList<int>> res = new List<IList<int>>();
            if (heights == null || heights.Length == 0)
                return res;

            int m = heights.Length, n = heights[0].Length;
            bool[,] pacific = new bool[m, n];
            bool[,] atlantic = new bool[m, n];

            for (int row = 0; row < m; row++)
            {
                DFS(row, 0, heights, pacific, heights[row][0]);
                DFS(row, n - 1, heights, atlantic, heights[row][n - 1]);
            }

            for (int col = 0; col < n; col++)
            {
                DFS(0, col, heights, pacific, heights[0][col]);
                DFS(m - 1, col, heights, atlantic, heights[m - 1][col]);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pacific[i, j] && atlantic[i, j])
                        res.Add(new List<int>(){i,j
});
                }
            }

            return res;
        }

        private void DFS(int row, int col, int[][] matrix, bool[,] reach, int prev)
        {
            int m = matrix.Length, n = matrix[0].Length;

            if (row < 0 || row >= m || col < 0 || col >= n || reach[row, col] || matrix[row][col] < prev)
                return;

            reach[row, col] = true;
            DFS(row, col + 1, matrix, reach, matrix[row][col]);
            DFS(row, col - 1, matrix, reach, matrix[row][col]);
            DFS(row + 1, col, matrix, reach, matrix[row][col]);
            DFS(row - 1, col, matrix, reach, matrix[row][col]);
        }
         void PrintMatrix(int[][] matrix)
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
            int[][] matrix = new int[5][]
           {
                new int[]{ 1,2,2,3,5 },
                 new int[]{ 3,2,3,4,4},
                 new int[]{ 2,4,5,3,1},
                 new int[]{ 6,7,1,4,5},
                 new int[]{ 5,1,1,2,4},

           };
            Program p = new Program();

            p.PrintMatrix(matrix);
            Console.WriteLine("\n");
            Console.WriteLine("Rotated Matrix is : " +"\n");
            IList<IList<int>> result =  p.PacificAtlantic(matrix);
            foreach(List<int> data in result)
            {
                Console.Write("[");
                for (int i = 0; i<data.Count; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.Write("]");
            }
            Console.WriteLine("\n");
        }
    }
}
