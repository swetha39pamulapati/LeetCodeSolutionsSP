using System;
using System.Collections.Generic;
using System.Text;

namespace _160.SerializeDeSerializeBinaryTree
{
    //https://www.youtube.com/watch?v=u4JAi2JJhI8
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
    class Program
    {
        //Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return Serialize(root, new StringBuilder()).ToString().Trim(',');
        }

        private StringBuilder Serialize(TreeNode root, StringBuilder str)
        {

            if (root == null) str.Append("#,");
            else
            {
                str.Append(root.val + ",");
                Serialize(root.left, str);
                Serialize(root.right, str);
            }

            return str;
        }

        private TreeNode ReDeserialize(Queue<string> l)
        {
            if (l.Peek().Equals("#"))
            {
                l.Dequeue();
                return null;
            }
            var root = new TreeNode(int.Parse(l.Dequeue()));
            root.left = ReDeserialize(l);
            root.right = ReDeserialize(l);
            return root;
        }

        public TreeNode deserialize(string data)
        {
            var queue = new Queue<string>(data.Split(','));
            return ReDeserialize(queue);
        }
        static void Main(string[] args)
        {
            TreeNode head = null;
            head = new TreeNode(1);
            head.left = new TreeNode(2);
            head.right = new TreeNode(3);
            head.right.left = new TreeNode(4);
            head.right.right = new TreeNode(5);
            Program p = new Program();
        string result =    p.serialize(head);
          TreeNode result1 =  p.deserialize(result);
            Console.WriteLine(result1);
        }
    }
}
