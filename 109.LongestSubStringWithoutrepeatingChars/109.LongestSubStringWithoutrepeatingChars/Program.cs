using System;
using System.Collections.Generic;

namespace _109.LongestSubStringWithoutrepeatingChars
{
    class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            int aPointer = 0;
            int max = 0;
            int bPointer = 0;
            HashSet<char> hashSet = new HashSet<char>();
            while (bPointer < s.Length)
            {
                if (!hashSet.Contains(s[bPointer]))
                {
                    hashSet.Add(s[bPointer]);
                    bPointer++;
                    max = Math.Max(hashSet.Count, max);
                }
                else
                {
                    hashSet.Remove(s[aPointer]);
                    aPointer++;
                }
        }
            return max;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string s = "abcabcbb";
           int data = p.LengthOfLongestSubstring(s);
            Console.WriteLine(data);
        }
    }
}
