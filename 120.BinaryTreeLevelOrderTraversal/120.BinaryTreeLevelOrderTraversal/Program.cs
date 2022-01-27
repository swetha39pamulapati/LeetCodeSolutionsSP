using System;
using System.Collections.Generic;
using System.Linq;

namespace _120.BinaryTreeLevelOrderTraversal
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count;
                var oneResult = new List<int>();
                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();
                    oneResult.Add(cur.val);

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }
                //result.Add(oneResult);
                result.Insert(0, oneResult);
            }

            //result.Reverse();

            return result;
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
            IList<IList<int>> result = p.LevelOrderBottom(root);
            Console.WriteLine(result.Count);
        }
    }
}
