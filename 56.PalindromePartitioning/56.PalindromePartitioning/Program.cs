using System;
using System.Collections.Generic;

namespace _56.PalindromePartitioning
{
    class Program
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<string>> result = new List<IList<string>>();
            if (s == null || s.Length == 0) return result;
            generatePalindromeString(0,s,new List<string>(), result);
            return result;
        }
       private void generatePalindromeString(int start,string str, List<string>list, List<IList<string>> result)
        {
            if(start == str.Length)
            {
                result.Add(new List<string>(list));
                return;
            }
            for (int i = 1; i + start <= str.Length; i++)
            {
                if (isPalindrome(str.Substring(start, i)))
                {
                    list.Add(str.Substring(start, i));
                    generatePalindromeString(start + i, str,list,  result);
                    list.RemoveAt(list.Count - 1);
                }
            }
            }
        private bool isPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            var left = 0;
            var right = str.Length - 1;
            while (left <= right)
            {
                if (str[left++] != str[right--])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            IList<IList<string>> result =  p.Partition("aab");
            Console.WriteLine(result.Count);
        }
    }
}
