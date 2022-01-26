using System;

namespace _110.KthSmallestElementBST
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
        public int KthSmallest(TreeNode root, int k)
        {
            int[] nums = new int[2];
            inorder(root, nums, k);
            return nums[1];
        }
        private void inorder(TreeNode root, int[] nums, int k)
        {
            if (root == null)
                return;
            inorder(root.left, nums, k);
            if (++nums[0] == k)
            {
                nums[1] = root.val;
                return;
            }
            inorder(root.right, nums, k);
        }
        static void Main(string[] args)
        {
            TreeNode root = null;
            root = new  TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);
            Program p = new Program();
         int data =   p.KthSmallest(root, 2);
            Console.WriteLine(data);
        }
    }
}
