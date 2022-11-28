using System;

namespace _82.NumberOfIslands
{
    //https://www.youtube.com/watch?v=U6-X_QOwPcs&t=11s
    class Program
    {
        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0 || grid == null)
                return 0;
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count += 1;
                        DFS(grid, i, j);
                    }
                }
            }
            return count;
        }
        public void DFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
                return;
            grid[i][j] = '0';
            DFS(grid, i + 1, j);
            DFS(grid, i - 1, j);
            DFS(grid, i, j - 1);
            DFS(grid, i, j + 1);
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
