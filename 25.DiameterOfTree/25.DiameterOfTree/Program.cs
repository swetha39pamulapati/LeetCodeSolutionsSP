using System;

namespace _25.DiameterOfTree
{
    class Node
    {
        public int val;
        public Node left, right;
    }
    class Program
    {
        private static int maxDiameter = 0;
        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.val = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }
        static int DFS(Node root)
        {
            if (root.left == null && root.right == null)
                return 0;
            var leftLength = 0;
            if (root.left != null)
                leftLength = DFS(root.left) + 1;

            var rightLength = 0;
            if (root.right != null)
                rightLength = DFS(root.right) + 1;
            var diameter = leftLength + rightLength;
            maxDiameter = Math.Max(diameter, maxDiameter);
            return Math.Max(leftLength, rightLength);

        }
        static int DiameterOfTree(Node root)
        {
            if (root == null)
                return 0;
            DFS(root);
            return maxDiameter;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            Console.WriteLine(DiameterOfTree(root));
            
        }
    }
}
