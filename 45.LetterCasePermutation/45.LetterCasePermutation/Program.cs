using System;
using System.Collections.Generic;
using System.Linq;

namespace _45.LetterCasePermutation
{
    class Program
    {
        public static IList<string> LetterCasePermutation(string s)
        {
            List<string> result = new List<string>();
            runDFS(s.ToCharArray(), 0, result);

            return result;
        }
        private static void runDFS(char[] arr, int start, List<string> result)
        {
            result.Add(new string(arr));
            for(int i = start;i<arr.Length; i++)
            {
                if (char.IsNumber(arr[i]))
                    continue;
                //deep copy - smart tip to make a copy of array using C#
                var next = arr.ToArray();
                var current = arr[i];
                 if(char.IsUpper(current))
            {
                next[i] = char.ToLower(current);
            }
            else
            {
                next[i] = char.ToUpper(current);
            }
            
            runDFS(next, i+1, result); 
            }
        }
            static void Main(string[] args)
        {
            string s = "a1b2";
            IList<string> result = LetterCasePermutation(s);
            if (result.Count > 0)
            {
                for(int i = 0; i< result.Count; 
                    i++)
                    Console.WriteLine(result[i]);
            }
           
        }
    }
}
