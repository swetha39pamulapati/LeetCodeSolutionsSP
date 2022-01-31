using System;
using System.Collections.Generic;

namespace _154.SubstringWithAllConcatenatedWords
{
    //https://www.youtube.com/watch?v=UV-hD94ytL4
    //https://leetcode.com/problems/substring-with-concatenation-of-all-words/discuss/476657/Accepted-C-Sliding-Window
    class Program
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            if (s == string.Empty || words.Length == 0)
            {
                return new List<int>();
            }

            List<int> res = new List<int>();

            Dictionary<string, int> word2Count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!word2Count.ContainsKey(word))
                {
                    word2Count[word] = 0;
                }

                word2Count[word]++;
            }

            int wordLength = words[0].Length;

            for (int j = 0; j < wordLength; j++)
            {
                Dictionary<string, int> wndState = new Dictionary<string, int>();
                int start = j;
                int count = 0;

                for (int i = j; i <= s.Length - wordLength; i += wordLength)
                {
                    string candidate = s.Substring(i, wordLength);
                    if (word2Count.ContainsKey(candidate))
                    {
                        if (!wndState.ContainsKey(candidate))
                        {
                            wndState[candidate] = 0;
                        }

                        wndState[candidate]++;
                        count++;

                        while (wndState[candidate] > word2Count[candidate])
                        {
                            string left = s.Substring(start, wordLength);
                            wndState[left]--;
                            count--;
                            start += wordLength;
                        }


                        if (count == words.Length)
                        {
                            res.Add(start);

                            string left = s.Substring(start, wordLength);
                            wndState[left]--;
                            count--;
                            start += wordLength;
                        }
                    }
                    else
                    {
                        wndState.Clear();
                        start = i + wordLength;
                        count = 0;
                    }
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] word = { "foo", "bar" };
            IList<int> result =  p.FindSubstring("barfoothefoobarman", word);
            Console.WriteLine(result.Count);
        }
    }
}
