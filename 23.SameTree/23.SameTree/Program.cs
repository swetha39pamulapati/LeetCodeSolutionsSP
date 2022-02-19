using System;

namespace _23.SameTree
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
        static bool sameTree(Node p, Node q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            if(p.val == q.val)
            {
                return sameTree(p.left, q.left) && sameTree(p.right, q.right);
            }
            return false;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);

            Node root1 = null;
            root1 = newNode(1);
            root1.left = newNode(2);
            root1.right = newNode(3);
           Console.WriteLine( sameTree(root, root1));
        
        }
    }
}
