using System;

namespace _70.PalindromicSubstrings
{
    class Program
    {
        public int CountSubstrings(string s)
		{ 
        if(String.IsNullOrEmpty(s)) return 0;
			int count = 0;
		for (int i = 0; i<s.Length; i++)
		{
		//odd
			count += ExpandAroundCenter(s, i, i);

		//even
		count += ExpandAroundCenter(s, i, i+1);
	}
	return count;
}

private int ExpandAroundCenter(string s, int start, int end)
{
	int counter = 0;
	while (start >= 0 && end < s.Length && s[start] == s[end])
	{
		counter++;
		start--;
		end++;
	}
	return counter;
}
static void Main(string[] args)
        {
            Program p = new Program();
            int data = p.CountSubstrings("abc");
            Console.WriteLine("Hello World!");
        }
    }
}
