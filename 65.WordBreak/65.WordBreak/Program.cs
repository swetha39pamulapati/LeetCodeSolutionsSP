using System;
using System.Collections.Generic;

namespace _65.WordBreak
{
    //https://www.youtube.com/watch?v=hLQYQ4zj0qg
    class Program
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var n = s.Length;
            var dp = new bool[n + 1];
            HashSet<string> set = new HashSet<string>(wordDict);
            dp[0] = true;
            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && set.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }

        static void Main(string[] args)
        {
            string s = "leetcode";
            IList< string> wordDict = new List<string>();
            wordDict.Add("leet");
            wordDict.Add("code");
            Program p = new Program();
            bool data = p.WordBreak(s, wordDict);
            Console.WriteLine(data);
        }
    }
}
