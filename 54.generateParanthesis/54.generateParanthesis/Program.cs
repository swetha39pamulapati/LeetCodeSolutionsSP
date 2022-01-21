using System;
using System.Collections.Generic;

namespace _54.generateParanthesis
{
    class Program
    {
        int max;
        List<string> result = new List<string>();
        public  IList<string> GenerateParenthesis(int n)
        {
            max = n;
            generateNParenthesis( 0, 0,"");
            return result;
        }
        public  void generateNParenthesis( int opened,int closed, string str)
        {
            
            if (opened == closed && opened == max)
            {
                result.Add(str);
                return;
            }
          if(opened< max)
                generateNParenthesis(opened + 1, closed, str + "(");
            if (closed < opened)
                generateNParenthesis( opened , closed+1, str + ")");

        }
            static void Main(string[] args)
        {
            Program p = new Program();
            IList<string> result = p.GenerateParenthesis(3);
            foreach (string i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
