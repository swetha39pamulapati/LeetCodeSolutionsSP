using System;

namespace _82.NumberOfIslands
{
    //https://www.youtube.com/watch?v=U6-X_QOwPcs&t=11s
    class Program
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count += 1;
                        BFS(grid, i, j);
                    }
                }
            }
            return count;
        }
        public void BFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
                return;
            grid[i][j] = '0';
            BFS(grid, i + 1, j);
            BFS(grid, i - 1, j);
            BFS(grid, i, j - 1);
            BFS(grid, i, j + 1);
        }
        static void Main(string[] args)
        {
                char[][] grid = new char[4][]
           {
                new char[]{ '1','1','1','1','0' },
                 new char[]{ '1','1','0','1','0'},
                 new char[]{ '1','1','0','0','0'},
                 new char[]{ '0','0','0','0','0'},

           };
            Program p = new Program();
            int result = p.NumIslands(grid);
            Console.WriteLine(result);
        }
    }
}
