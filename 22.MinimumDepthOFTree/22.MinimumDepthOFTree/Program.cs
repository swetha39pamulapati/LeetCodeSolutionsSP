using System;

namespace _22.MinimumDepthOFTree
{
    class Node
    {
        public int val;
        public Node left, right;
    }
    class Program
    {
        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.val = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }
        public static int MinDepth(Node root)
        {
            if (root == null)
                return 0;
            if (root.left != null)
                return MinDepth(root.left) +1;
            if (root.right != null)
                return MinDepth(root.right) + 1;
                    
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1; ;
        }
            static void Main(string[] args)
        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(9);
            root.right = newNode(20);
            //root.left.left = newNode(3);
            //root.left.right = newNode(5);
            root.right.left = newNode(7);
            root.right.right = newNode(15);
            Console.WriteLine("Min Depth : ");

            Console.WriteLine(MinDepth(root));
        }
    }
}
