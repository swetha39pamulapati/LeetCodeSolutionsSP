using System;
using System.Collections.Generic;

namespace _127.PathSumiii
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
        int count = 0;
        public int PathSum(TreeNode root, int targetSum)
        {
            //if (targetSum == 0)
            //    return 0;
            List<int> result = new List<int>();
            generateSum(root, targetSum, result);

            return count;
        }
        public void generateSum(TreeNode root, int targetSum, List<int> result)
        {
            if (root == null)
                return;
            result.Add(root.val);
            generateSum(root.left, targetSum, result);
            generateSum(root.right, targetSum, result);
            int temp = 0;
            for(int i =result.Count -1; i>=0; i--)
            {
                temp += result[i];
                if (temp == targetSum)
                    count++;
            }
            result.RemoveAt(result.Count - 1);
        }
        static void Main(string[] args)
        {
            TreeNode root = null;
            root = new TreeNode(0);
            root.left = new TreeNode(1);
            root.right = new TreeNode(1);
            //root.left.left = new TreeNode(11);
            //root.left.left.left = new TreeNode(7);
            //root.left.left.right = new TreeNode(2);
            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(4);
            //root.right.right.left = new TreeNode(5);
            //root.right.right.right = new TreeNode(1);
            Program p = new Program();
            int  result = p.PathSum(root, 0);
            Console.WriteLine(result);
        }
    }
}
