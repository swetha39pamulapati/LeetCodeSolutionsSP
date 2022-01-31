using System;

namespace _141.MaximumXOR2Numbers
{
    class Program
    {
        public class TrieNode
        {
            public TrieNode[] Children;

            public TrieNode()
            {
                Children = new TrieNode[2];
            }
        }
        public int FindMaximumXOR(int[] nums)
        {

            // build the Trie
            TrieNode root = new TrieNode();

            foreach (int num in nums)
            {
                TrieNode curr = root;

                for (int i = 31; i >= 0; i--)
                {
                    int currBit = (num & (1 << i)) == 0 ? 0 : 1;
                    if (curr.Children[currBit] == null)
                    {
                        curr.Children[currBit] = new TrieNode();
                    }

                    curr = curr.Children[currBit];
                }
            }

            // find the maximum XOR
            int res = 0;
            foreach (int num in nums)
            {
                TrieNode curr = root;
                int currMax = 0;

                for (int i = 31; i >= 0; i--)
                {
                    int currBit = (num & (1 << i)) == 0 ? 0 : 1;
                    int flipBit = currBit ^ 1;

                    if (curr.Children[flipBit] != null)
                    {
                        currMax += 1 << i;
                        curr = curr.Children[flipBit];
                    }
                    else
                        curr = curr.Children[currBit];
                }

                res = Math.Max(res, currMax);
            }

            return res;
        }
    
    static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 3, 10, 5, 25, 2, 8 };
           int result =  p.FindMaximumXOR(nums);
            Console.WriteLine(result);
        }
    }
}
