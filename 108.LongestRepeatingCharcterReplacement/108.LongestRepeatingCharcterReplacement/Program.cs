using System;

namespace _108.LongestRepeatingCharcterReplacement
{
    class Program
    {
        //https://www.youtube.com/watch?v=00FmUN1pkGE
        public int characterReplacement(string s, int k)
        {
            int n = s.Length;
            int[] charCounts = new int[26];
            int windowStart = 0;
            int maxLength = 0;
            int maxCount = 0;
            for(int windowEnd =0; windowEnd<n; windowEnd++)
            {
                charCounts[s[windowEnd] - 'A']++;
                int currentCharCount = charCounts[s[windowEnd] - 'A'];
                maxCount = Math.Max(maxCount, currentCharCount);
                while(windowEnd - windowStart - maxCount + 1 > k)
                {


                    charCounts[s[windowStart] - 'A']--;
                    windowStart++;


                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            string s = "AABABBA"; int k = 1;
          int data =  p.characterReplacement(s, k);
            Console.WriteLine(data);
        }
    }
}
