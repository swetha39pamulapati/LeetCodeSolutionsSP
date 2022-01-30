using System;

namespace _133.ValidateBinarySearch
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
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return dfs(root, null, null);
        }
        private bool dfs(TreeNode root, int? min, int? max)
        {
            if (root == null)
                return true;
            if ((min != null && root.val <= min) || (max != null && root.val >= max))
            {
                return false;
            }
            return dfs(root.left, min, root.val) && dfs(root.right, root.val, max);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            bool result = p.IsValidBST(root);
            Console.WriteLine(result);
        }
    }
}
