using System;

namespace _33.BacspaceStringCompare
{
    class Program
    {
        public static bool BackspaceCompare(string S, string T)
        {
            string data1 = string.Empty;
            string data2 = string.Empty;
            foreach(char c in S)
            {
                if (c != '#')
                {
                    data1 += c.ToString();
                }
                else if (data1.Length > 0)
                {
                    data1 = data1.Remove(data1.Length - 1);
                }
            }

            foreach (char c in T)
            {
                if (c != '#')
                {
                    data2 += c.ToString();
                }
                else if (data2.Length > 0)
                {
                    data2 = data2.Remove(data2.Length - 1);
                }
            }
            return data1 == data2;
        }
            static void Main(string[] args)
        {
            string string1 = "ab#c";
            string string2 = "ad#c";
            string s = "a#c";
            string t = "b";
          Console.WriteLine(BackspaceCompare(string1, string2));
            //Console.WriteLine(BackspaceCompare(s, t));

        }
    }
}
