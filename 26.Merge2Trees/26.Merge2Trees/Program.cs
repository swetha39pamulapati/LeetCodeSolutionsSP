using System;

namespace _26.Merge2Trees
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
        public static Node MergeTrees(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return null;
            if (root1 == null)
                return root2;
            if(root2 == null)
                return root1;
            var data = root1.val + root2.val;
              var root= newNode(data);
            root.left = MergeTrees(root1.left, root2.left);
            root.right = MergeTrees(root1.right, root2.right);

            return root;


        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(1);
            root.left = newNode(3);
            root.right = newNode(2);
            root.left.left = newNode(5);


            Node root1 = null;
            root1 = newNode(2);
            root1.left = newNode(1);
            root1.right = newNode(3);
            root1.left.right = newNode(4);
            root1.right.right = newNode(7);
            Node data = MergeTrees(root, root1);
            Console.WriteLine(data);
        }
    }
}
