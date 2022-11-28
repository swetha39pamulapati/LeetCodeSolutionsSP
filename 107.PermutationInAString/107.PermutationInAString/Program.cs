using System;

namespace _107.PermutationInAString
{
    class Program
    {
        //https://www.youtube.com/watch?v=XFh_AoEdOTw
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int len1 = s1.Length, len2 = s2.Length;
            int[] freq = new int[26];
            int[] freq2 = new int[26];
            for (int i = 0; i < len1; i++)
            {
                freq[s1[i] - 'a']++;
                freq2[s2[i] - 'a']++;
            }

            // fix the size of sliding window as len1  
            int left = 0, right = len1 - 1;

            while (right < len2)
            {
                if (IsEqual(freq, freq2))
                    return true;

                right++;
                if (right < len2)
                    freq2[s2[right] - 'a']++;

                freq2[s2[left] - 'a']--;
                left++;
            }

            return false;
        }

        private bool IsEqual(int[] freq1, int[] freq2)
        {
            for (int i = 0; i < freq1.Length; i++)
            {
                if (freq1[i] != freq2[i])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string s1 = "ab", s2 = "eidbaooo";
         bool data =    p.CheckInclusion(s1, s2);
            
            Console.WriteLine(data);
        }
    }
}
