using System;

namespace _30.InvertBinaaryTree
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
        static Node invertBinaaryTree(Node root)
        {
            if (root == null)
                return null;
            var node = newNode(root.val);
            node.left = invertBinaaryTree(root.right);
            node.right = invertBinaaryTree(root.left);
            return node;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(1);
            root.left = newNode(3);
            root.right = newNode(2);
            Node result = invertBinaaryTree(root);
            Console.WriteLine(result);
        }
    }
}
