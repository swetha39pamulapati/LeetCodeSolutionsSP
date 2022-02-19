using System;

namespace _29.SubTreeOfAnotherTree
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
        public static bool IsSubtree(Node root,Node subRoot)
        {
            if (root == null)
                return false;
            if (root.val == subRoot.val)
            {
                if (IsSame(root, subRoot))
                    return true;
            }

            return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
        }

        private static bool IsSame(Node s, Node t)
        {
            if (s == null && t == null)
                return true;
            if (s != null && t == null || t != null && s == null || s.val != t.val)
                return false;
            return (IsSame(s.left, t.left) && IsSame(s.right, t.right));
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(4);
            root.right = newNode(5);
            root.left.left = newNode(1);
            root.left.right = newNode(2);

            Node root1 = null;
            root1 = newNode(4);
            root1.left = newNode(1);
            root1.right = newNode(2);
            Console.WriteLine(IsSubtree(root, root1));
        }
    }
}
