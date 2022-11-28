using System;

namespace _64.LongestPalindromicSubstring
{
    class Program
    {
        //private int ExpandAroundCenter(string s, int start, int end)
        //{

        //    while (start >= 0 && end < s.Length && s[start] == s[end])
        //    {

        //        start--;
        //        end++;
        //    }
        //    return end-start-1;
        //}
        public string LongestPalindrome(string s)
        {
            //    int start = 0, end = 0, len=0;
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        int odd  = ExpandAroundCenter(s, i, i);
            //        int even = ExpandAroundCenter(s, i, i+1);
            //         len = Math.Max(odd, even);
            //        if ( len < end- start +1 )
            //        {
            //            start = i - (len - 1) / 2;
            //            end = i + len / 2;
            //        }
            //    }
            //    return s.Substring(start, end+1);

            int maxLength = 0, startIndex = 0;
            for (int i = 0; i<s.Length; i++)
            {
                int start = i, end = i;
                //even
                while (end<s.Length - 1 && s[start] == s[end + 1])
                    end++;
                //odd length
                while (end<s.Length - 1 && start> 0 && s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                if (maxLength<end - start + 1)
                {
                    maxLength = end - start + 1;
                    startIndex = start;
                }
            }
            return s.Substring(startIndex, maxLength);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
          string data =   p.LongestPalindrome("babad");
            Console.WriteLine(data);
        }
    }
}
