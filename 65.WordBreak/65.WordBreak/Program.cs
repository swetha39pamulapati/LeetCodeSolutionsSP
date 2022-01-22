using System;
using System.Collections.Generic;

namespace _65.WordBreak
{
    class Program
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var dict = new Dictionary<string, bool>();
            return WB(s, wordDict, dict);
        }

        bool WB(string s, IList<string> wordDict, IDictionary<string, bool> dict)
        {
            if (dict.ContainsKey(s))
            {
                return dict[s];
            }
            foreach (var word in wordDict)
            {
                if (s == word || s.StartsWith(word) && WB(s.Substring(word.Length, s.Length - word.Length), wordDict, dict))
                {
                    dict[s] = true;
                    return true;
                }
            }
            dict[s] = false;
            return false;
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
