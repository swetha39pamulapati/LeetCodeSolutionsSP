using System;
using System.Text;

namespace _155.ReArrangeStringKdistanceApart
{
//    Since this is a greedy question, for sure we need to consider placing the characters with higher frequencies first. Thus we first construct a map between characters and their corresponding frequencies. Meanwhile, since the same character must be at least distance k from each other, we keep another map between each character and their next valid position, say we have put 'a' at index i, then the next valid position of 'a' should be greater than or equal to i + k.

//During the process we iterate through the input String, we first get the first character among 'a' to 'z' that satisfy:

//It has the highest frequency among the remaining characters.
//Current index we are considering is at least distance k from the previous position of this character, that is to say, the next valid position of this character should be less than or equal to current index.
//If we cannot find a match, that means a result satisfies the question requirement is not possible, return "".

//Otherwise, we reduce frequency of current character by 1 and update its next valid position.

//Time complexity: O(26*n) = O(n) where n is the length of the input string.
    class Program
    {
        public string rearrangeString(string s, int k)
        {
            int len = s.Length;
            int[] count = new int[26];
            int[] nextPosition = new int[26];
            for (int i = 0; i < len; i++)
            {
                count[s[i] - 'a']++;
            }
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < len; index++)
            {
                int candidate = findCandidate(count, nextPosition, index);
                if (candidate == -1) return "";
                count[candidate]--;
                nextPosition[candidate] = index + k;
                sb.Append((char)('a' + candidate));
            }

            return sb.ToString();
        }

        private int findCandidate(int[] count, int[] nextPosition, int index)
        {
            int max = int.MinValue;
            int candidate = -1;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0 && count[i] > max && index >= nextPosition[i])
                {
                    max = count[i];
                    candidate = i;
                }
            }

            return candidate;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
          string result =  p.rearrangeString("aabbcc", 3);
            Console.WriteLine(result);
        }
    }
}
