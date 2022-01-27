using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _113.SortcharsbyFrequency
{
    class Program
    {
        public string FrequencySort(string s)
        {
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
            var ordered = di.OrderByDescending(x => x.Value).ToList();
            var sb = new StringBuilder();

            foreach (var val in ordered)
            {
                sb.Append(val.Key, val.Value);
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string s = "tree";
            Program p = new Program();
           string result = p.FrequencySort(s);
            Console.WriteLine(result);
        }
    }
}
