using System;

namespace _28.LCAOfBinaryTree
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
      public static Node LCAOfBinaryTree(Node root, Node p, Node q)
        {
            if (root == null)
                return null;
            if(p.val< root.val && q.val< root.val)
            {
                return LCAOfBinaryTree(root.left, p, q);


            }
            else if (p.val > root.val && q.val > root.val)
                return LCAOfBinaryTree(root.right, p, q);
        return root;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(1);
            root.right = newNode(2);
            Node result = LCAOfBinaryTree(root, newNode(1), newNode(2));
            Console.WriteLine(result.val);
        }
    }
}
