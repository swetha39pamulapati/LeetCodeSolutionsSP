using System;

namespace _123.PopulateNextRightPointerBinaryTree
{
    //https://www.youtube.com/watch?v=30Bqbk-Vk3Q&t=344s
    class Program
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        public Node Connect(Node root)
        {

            if (root == null)
                return null;

            Node leftMost = root;

            while (leftMost.left != null)
            {
                Node curr = leftMost;
                while (curr != null)
                {
                    curr.left.next = curr.right;

                    if (curr.next != null)
                    {
                        curr.right.next = curr.next.left;
                    }

                    curr = curr.next;
                }

                leftMost = leftMost.left;
            }

            return root;
        }
            static void Main(string[] args)
        {
            Program p = new Program();
            Node root = null;
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            Node result = p.Connect(root);
            Console.WriteLine(result);
        }
    }
}
