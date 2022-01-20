using System;

namespace _43.WordSearch
{
    class Program
    {
        
        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int columns = board[0].Length;
            var isVisited = new bool[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(word[0] == board[i][j] && searchWord(i, j, board, word, isVisited, 0))
                    {
                        return true;
                    }
                }
            }
           return false;
        }
        private static bool searchWord(int i, int j,char[][] board,string word,bool[,] visited,int index)
        {
            if (index == word.Length)
                return true;
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length|| visited[i, j] || board[i][j] != word[index])
                return false;
            visited[i, j] = true;
            //4 directions top bottom left, right
            if(searchWord(i+1, j ,board,word, visited, index +1) ||
                searchWord(i-1 , j, board, word, visited, index + 1) ||
                searchWord(i , j+1, board, word, visited, index + 1)||
                searchWord(i , j-1, board, word, visited, index + 1)
                    )
            {
                return true;
            }
            visited[i, j] = false;
            return false;
        }
            static void PrintMatrix(char[][] matrix)
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
            char[][] matrix = new char[2][]
            {
                //new char[]{ 'A', 'B', 'C','E' },
                // new char[]{'S','F','C','S' },
                //  new char[]{ 'A','D','E','E' },


                   new char[]{ 'A', 'B' },
                 new char[]{'C','D' },
                  


            };
            PrintMatrix(matrix);
        bool result =     Exist(matrix, "CDBA");
            Console.WriteLine(result);
        }
    }
}
