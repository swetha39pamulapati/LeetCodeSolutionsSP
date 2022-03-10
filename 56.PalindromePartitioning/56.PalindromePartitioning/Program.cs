using System;
using System.Collections.Generic;

namespace _56.PalindromePartitioning
{
    class Program
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Part(0, s, result, new List<string>());
            return result;
        }
        public bool IsPali(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left++] != s[right--]) 
                    return false;
            }
            return true;
        }

        public void Part(int start, string s, IList<IList<string>> result, List<string> list)
        {
            if (start == s.Length)
            {
                result.Add(new List<string>(list));
                return;
            }

            for (int i = start; i < s.Length; i++)
            {
                if (IsPali(s, start, i))
                {
                    list.Add(s.Substring(start, i - start + 1));
                    Part(i + 1, s, result, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            IList<IList<string>> result =  p.Partition("aab");
            Console.WriteLine(result.Count);
        }
    }
}
