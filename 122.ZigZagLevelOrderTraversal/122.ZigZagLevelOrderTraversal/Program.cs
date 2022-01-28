using System;
using System.Collections.Generic;

namespace _122.ZigZagLevelOrderTraversal
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();

            if (root == null)
                return res;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int rowNum = 0;
            while (queue.Count > 0)
            {
                List<int> row = new List<int>();
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    row.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                if (rowNum % 2 == 1)
                    row.Reverse();

                res.Add(row);

                rowNum++;
            }

            return res;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = null;
            root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            IList<IList<int>> result = p.ZigzagLevelOrder(root);
            Console.WriteLine(result.Count);
        }
    }
}
