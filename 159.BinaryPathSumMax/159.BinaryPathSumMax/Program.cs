using System;

namespace _159.BinaryPathSumMax
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
    class Program
    {
        int maxPathSum;
        public int MaxPathSum(TreeNode root)
        {
            maxPathSum = int.MinValue;
            pathSum(root);
            return maxPathSum;

        }
        public int pathSum(TreeNode node)
        {
            if (node == null)
                return 0;
            int left = Math.Max(0, pathSum(node.left));
            int right = Math.Max(0, pathSum(node.right));
            maxPathSum = Math.Max(maxPathSum, left + right + node.val);
            return Math.Max(left, right) + node.val;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode head = null;
            head = new TreeNode(1);
            head.left = new TreeNode(2);
            head.right = new TreeNode(3);
           int result =  p.MaxPathSum(head);
            Console.WriteLine(result);
        }
    }
}
