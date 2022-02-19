using System;

namespace _24.PathSum
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
        public static bool HasPathSum(Node root, int targetSum)
        {

            if (root == null)
                return false;
            if (root.left == null && root.right == null & targetSum == root.val)
                return true;
            
            return HasPathSum(root.left,targetSum-root.val) || HasPathSum(root.right, targetSum - root.val);

        }
        static void Main(string[] args)
        {
            //Node root1 = null;
            //root1 = newNode(1);
            //root1.left = newNode(2);
            //root1.right = newNode(3);

            Node root = null;
            root = newNode(5);
            root.left = newNode(4);
            root.right = newNode(8);
            root.left.left = newNode(11);
            root.right.left = newNode(13);
            root.right.right = newNode(4);
            root.left.left.left = newNode(7);
            root.left.left.right = newNode(2);
            root.right.right.right = newNode(1);

           //Console.WriteLine( HasPathSum(root1, 5));
            Console.WriteLine(HasPathSum(root, 22));
        }
    }
}

