using System;
using System.Collections.Generic;

namespace _125.RightViewBinaryTree
{
    class Program
    {
        //https://leetcode.com/problems/binary-tree-right-side-view/discuss/294305/C-BFS
        //https://www.youtube.com/watch?v=jCqIr_tBLKs
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
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
                return result;
           
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count;
                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();
                    if (s == size - 1)
                    {
                        result.Add(cur.val);
                    }
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = null;
            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);
            root.right.right = new TreeNode(4);
            IList<int> result = p.RightSideView(root);
            Console.WriteLine(result);
        }
    }
}
