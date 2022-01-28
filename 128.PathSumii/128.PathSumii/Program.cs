using System;
using System.Collections.Generic;

namespace _128.PathSumii
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
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<IList<int>> result = new List<IList<int>>();
            findPath(root, targetSum, new List<int>(), result);
            return result;

        }
        public void findPath(TreeNode root, int targetSum,  List<int>current, List<IList<int>> paths)
        {
            if (root == null)
                return;
            current.Add(root.val);
            //reached leafnode
            if(root.val == targetSum && root.left==null && root.right== null)
            {
                paths.Add(current);
            }
            findPath(root.left, targetSum-root.val, new List<int>(current), paths);
            findPath(root.right, targetSum-root.val, new List<int>(current), paths);
        }
        static void Main(string[] args)
        {
            TreeNode root = null;
            root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.left = new TreeNode(5);
            root.right.right.right = new TreeNode(1);
            Program p = new Program();
            IList<IList<int>> result = p.PathSum(root, 22);
            Console.WriteLine(result);
        }
    }
}
