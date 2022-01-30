using System;

namespace _132.ConstructBinaryTreePreOrderInordr
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
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var n = preorder.Length;
            if (n == 0) return null;

            return DFS(preorder, 0, n - 1, inorder, 0, n - 1);
        }

        private TreeNode DFS(int[] preorder, int preLeft, int preRight, int[] inorder, int inLeft, int inRight)
        {
            if (preLeft > preRight)
                return null;

            var rootValue = preorder[preLeft];
            var rootInIndex = -1;

            for (int i = inLeft; i <= inRight; i++)
            {
                if (inorder[i] == rootValue)
                {
                    rootInIndex = i;
                    break;
                }
            }

            var count = rootInIndex - inLeft;

            var root = new TreeNode(rootValue);

            root.left = DFS(preorder, preLeft + 1, preLeft + count, inorder, inLeft, rootInIndex - 1);
            root.right = DFS(preorder, preLeft + count + 1, preRight, inorder, rootInIndex + 1, inRight);

            return root;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] preOrder = { 1, 2, 4, 8, 9, 10, 11, 5, 3, 6, 7 };
            int[] inorder = { 8, 4, 10, 9, 11, 2, 5, 1, 6, 3, 7 };
            int length = inorder.Length;
            TreeNode root = p.BuildTree(preOrder,inorder );
            //p.printInorder(root);
        }
    }
}
