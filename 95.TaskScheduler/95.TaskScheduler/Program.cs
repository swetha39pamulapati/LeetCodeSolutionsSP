using System;

namespace _95.TaskScheduler
{
    //https://www.youtube.com/watch?v=eGf-26OTI-A
    class Program
    {
        public int LeastInterval(char[] tasks, int n)
        {

            int maxFreq = 0, interval = 0, cnt = 0;
            int[] freq = new int[26];


            foreach (char t in tasks)
            {
                freq[t - 'A']++;

                // Find the most frequent task
                if (freq[t - 'A'] > maxFreq)
                {
                    maxFreq = freq[t - 'A'];
                    cnt = 1;
                }
                // Count the number of most frequent tasks
                else if (freq[t - 'A'] == maxFreq)
                    cnt++;
            }

            // maxFreq - 1: blocks needed to allocate the first maxFreq-1 most-frequent task
            // n + 1: each block needs n+1 spaces due the the cooling interval.
            // cnt: Size of last block = number of most-frequent tasks
            interval = (maxFreq - 1) * (n + 1) + cnt;

            return interval < tasks.Length ? tasks.Length : interval;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            char[] tasks = { 'A','A','A', 'B','B','B'  };
            int n = 2;
           int result =  p.LeastInterval(tasks,n);
            Console.WriteLine(result);
        }
    }
}
