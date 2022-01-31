using System;
using System.Collections.Generic;

namespace _157.MaxFreqStack
{
    //https://www.geeksforgeeks.org/design-a-stack-which-can-give-maximum-frequency-element/
    class FreqStack
    {
        private int maxFreq = 0;
        private Dictionary<int, int> freq; // number, occurrence
        private Dictionary<int, Stack<int>> maxFreqs; // occurrence, numbers

        public FreqStack()
        {
            freq = new Dictionary<int, int>();
            maxFreqs = new Dictionary<int, Stack<int>>();
        }

        public void Push(int x)
        {
            if (freq.ContainsKey(x))
                freq[x]++;
            else
                freq.Add(x, 1);

            maxFreq = Math.Max(maxFreq, freq[x]);

            if (maxFreqs.ContainsKey(freq[x]))
                maxFreqs[freq[x]].Push(x);
            else
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(x);
                maxFreqs.Add(freq[x], stack);
            }
        }

        public int Pop()
        {
            int res = maxFreqs[maxFreq].Pop();

            freq[res]--;

            if (maxFreqs[maxFreq].Count == 0)
                maxFreq--;

            return res;
        }
        static void Main(string[] args)
        {
            FreqStack p = new FreqStack();
            p.Push(5);
            p.Push(7);
            p.Push(5);
            p.Push(7);
            p.Push(4);
            p.Push(5);
            p.Pop();
            p.Pop();
            p.Pop();
          int result =  p.Pop();
            Console.WriteLine(result);
        }
    }
}
