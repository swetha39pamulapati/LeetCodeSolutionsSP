using System;

namespace _152.CountUniqueCharsOfAllSubstringsofAString
{
    class Program
    {
		//https://leetcode.com/problems/count-unique-characters-of-all-substrings-of-a-given-string/discuss/129410/C-Solution
		public int UniqueLetterString(string s)
		{
			var ans = 0;
			var count = 0;
			int[] lastCount = new int[26];
			int[] lastSeen = new int[26];
			System.Array.Fill(lastSeen, -1);
			for (var i = 0; i < s.Length; ++i)
			{
				var c = (int)(s[i]) - (int)('A');
				var currentCount = i - lastSeen[c];
				count = count - lastCount[c] + currentCount;
				lastCount[c] = currentCount;
				lastSeen[c] = i;
				ans += count;
			}
			return ans;
		}
		static void Main(string[] args)
        {
			Program p = new Program();
		int result = 	p.UniqueLetterString("ABC");
            Console.WriteLine(result);
        }
    }
}
