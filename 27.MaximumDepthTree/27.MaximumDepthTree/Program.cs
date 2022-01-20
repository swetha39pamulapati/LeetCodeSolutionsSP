using System;

namespace _27.MaximumDepthTree
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
        public static int maximumDepthTree(Node root)
        {
            if (root == null)
                return 0;
            return Math.Max(maximumDepthTree(root.left), maximumDepthTree(root.right)) + 1;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(20);
            root.right = newNode(9);
            root.left.left = newNode(23);

            Console.WriteLine(maximumDepthTree(root));
        }
    }
}
