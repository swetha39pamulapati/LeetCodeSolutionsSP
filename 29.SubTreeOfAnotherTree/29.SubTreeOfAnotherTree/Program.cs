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
        static bool subTreeOrNot(Node root, Node subRoot)
        {
            if (root != null)
            {
                return IsSame(root, subRoot) || subTreeOrNot(root.left, subRoot) || subTreeOrNot(root.right, subRoot);
            }
            return subRoot == null;
        }
        private static bool IsSame(Node left, Node right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;

            return left.val == right.val
                    && IsSame(left.left, right.left)
                    && IsSame(left.right, right.right);
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
            Console.WriteLine(subTreeOrNot(root, root1));
        }
    }
}
