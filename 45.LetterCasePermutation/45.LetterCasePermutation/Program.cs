using System;
using System.Collections.Generic;
using System.Linq;

namespace _45.LetterCasePermutation
{
    class Program
    {
        public static IList<string> LetterCasePermutation(string s)
        {
            if (string.IsNullOrEmpty(s))
                return new List<string>() { string.Empty };
            var list = new List<string>();
            list.Add(s);
            Permutation(s.ToCharArray(), 0, list);
            return list;
        }

        public static void Permutation(char[] s, int i, List<string> list)
        {
            if (i == s.Length) 
                return;
            if (char.IsLetter(s[i]))
            {
                var temp = s[i];
                Permutation(s, i + 1, list);
                s[i] = char.IsLower(s[i]) ? char.ToUpper(s[i]) : char.ToLower(s[i]);
                Permutation(s, i + 1, list);
                list.Add(new string(s));
                s[i] = temp;
            }
            else 
                Permutation(s, i + 1, list);
        }
            static void Main(string[] args)
        {
            string s = "a1b2";
            IList<string> result = LetterCasePermutation(s);
            if (result.Count > 0)
            {
                for(int i = 0; i< result.Count;i++)
                    Console.WriteLine(result[i]);
            }
           
        }
    }
}
