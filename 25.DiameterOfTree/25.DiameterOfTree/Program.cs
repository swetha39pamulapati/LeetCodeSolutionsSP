using System;

namespace _25.DiameterOfTree
{
    //https://www.youtube.com/watch?v=DcDjYOsjSlg
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
        static int DiameterOfTree(Node root)
        {

            DFS(root);
            return maxDiameter;
        }
        static int DFS(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftLength = DFS(node.left);
            int rightLength = DFS(node.right);

            var diameter = leftLength + rightLength;
            maxDiameter = Math.Max(maxDiameter, diameter);
            return Math.Max(leftLength, rightLength) + 1;

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
