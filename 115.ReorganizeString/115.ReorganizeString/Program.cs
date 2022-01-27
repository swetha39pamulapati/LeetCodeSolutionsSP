using System;
using System.Collections.Generic;
using System.Linq;

namespace _115.ReorganizeString
{
    class Program
    {
        public string ReorganizeString(string s)
        {
            int length = s.Length;
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            var di = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {

                if (di.ContainsKey(s[i]))
                {
                    di[s[i]] += 1;
                }
                else
                {
                    di.Add(s[i], 1);
                }
            }
            var newHash = di.OrderByDescending(x => x.Value);
            if (newHash.First().Value > (s.Length + 1) / 2) return "";

            char[] answer = new char[length];
            int idx = 0;
            foreach (var kvp in newHash)
            {
                int max = kvp.Value;
                for (int i = 0; i < max; i++)
                {
                    if (idx < length)
                    {
                        answer[idx] = kvp.Key;
                        idx += 2;
                    }
                    else if (answer[0] != kvp.Key)
                    {
                        idx = 1;
                        answer[idx] = kvp.Key;
                        idx += 2;
                    }
                    else return "";
                }
            }

            return new string(answer);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
          string result =  p.ReorganizeString("aab");
            Console.WriteLine(result);
        }
    }
}
