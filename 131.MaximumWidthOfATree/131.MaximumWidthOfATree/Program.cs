using System;
using System.Collections.Generic;

namespace _134.MaximumWidthOfTree
{
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
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            int max = 1;
            Queue<(TreeNode, int)> q = new Queue<(TreeNode, int)>();
            q.Enqueue((root, 0));
            while (q.Count > 0)
            {
                int n = q.Count;
                int left = -1, right = -1;
                while (n-- > 0)
                {
                    var cur = q.Dequeue();
                    if (left == -1) left = cur.Item2;
                    right = cur.Item2;
                    if (cur.Item1.left != null) q.Enqueue((cur.Item1.left, 2 * cur.Item2));
                    if (cur.Item1.right != null) q.Enqueue((cur.Item1.right, 2 * cur.Item2 + 1));
                }
                max = Math.Max(right - left + 1, max);
            }
            return max;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            int result = p.WidthOfBinaryTree(root);
            Console.WriteLine(result);
        }
    }
}
