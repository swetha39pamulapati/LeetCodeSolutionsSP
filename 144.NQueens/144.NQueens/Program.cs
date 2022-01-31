using System;
using System.Collections.Generic;

namespace _144.NQueens
{
    //https://www.youtube.com/watch?v=hnJI-4npsCQ
    class Program
    {
        private int n;
        private IList<IList<string>> ans;
        private char[][] chesstable;

        public IList<IList<string>> SolveNQueens(int n)
        {
            this.n = n;
            this.ans = new List<IList<string>>();
            this.chesstable = new char[n][];
            for (int i = 0; i < n; i++)
            {
                chesstable[i] = new char[n];
                Array.Fill(chesstable[i], '.');
            }
            backtrack(0);
            return ans;
        }

        bool IsValid(int row, int col)
        {
            for (int i = 0; i < row; i++)
                if (chesstable[i][col] == 'Q')
                    return false;

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
                if (chesstable[i][j] == 'Q')
                    return false;

            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
                if (chesstable[i][j] == 'Q')
                    return false;

            return true;
        }

        void backtrack(int row)
        {
            if (row == n)
            {
                var res = new List<string>();
                for (int i = 0; i < n; i++)
                    res.Add(new string(chesstable[i]));
                ans.Add(res);
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(row, col))
                {
                    chesstable[row][col] = 'Q';
                    backtrack(row + 1);
                    chesstable[row][col] = '.';
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
