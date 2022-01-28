using System;

namespace _130.MaximumBinaryTree
{
    //https://www.youtube.com/watch?v=6qHhp1XibMU
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return constructMaximumBinaryTree(nums, 0, nums.Length - 1);
        }
        public TreeNode constructMaximumBinaryTree(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            var maxStartIndex = start;
            for(int i =start+1; i<=end; i++)
            {
                if(nums[i]>nums[maxStartIndex])
                {
                    maxStartIndex = i;
                }
            }
            var node = new TreeNode(nums[maxStartIndex]);
          node.left =  constructMaximumBinaryTree(nums, start, maxStartIndex - 1);
          node.right =  constructMaximumBinaryTree(nums, maxStartIndex+1, end);
            return node;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            
            int[] nums = { 3, 2, 1, 6, 0, 5 };
         TreeNode result =   p.ConstructMaximumBinaryTree(nums);
            Console.WriteLine(result.val);
        }
    }
}
