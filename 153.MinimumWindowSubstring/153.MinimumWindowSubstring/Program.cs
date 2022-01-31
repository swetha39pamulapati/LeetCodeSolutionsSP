using System;

namespace _153.MinimumWindowSubstring
{
    class Program
    {
        //https://www.youtube.com/watch?v=yT5nzi9f_T4
             public string MinWindow(string s, string t)
        {
            int start = 0, end = 0, count = t.Length;
            var freq = new int[128];
            var result = string.Empty;
            foreach (var ch in t) freq[ch]++;
            while (end < s.Length)
            {
                if (freq[s[end++]]-- > 0) count--;
                while (count == 0)
                {
                    if (string.IsNullOrEmpty(result) || end - start < result.Length)
                        result = s.Substring(start, end - start);
                    if (freq[s[start++]]++ == 0)
                        count++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           string result =  p.MinWindow("ADOBECODEBANC", "ABC");
            Console.WriteLine(result);
        }
    }
}
