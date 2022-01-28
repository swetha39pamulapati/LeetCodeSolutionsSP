using System;

namespace _124.NextrightPointerBT2
{
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

            Node levelHead = null; // first node of the next level
            Node prev = null; // last visited node in the next level
            Node curr = root; // current node in the current level

            while (curr != null)
            {
                while (curr != null)
                {
                    if (curr.left != null)
                    {
                        if (prev == null)
                        {
                            levelHead = curr.left;
                            prev = curr.left;
                        }
                        else
                        {
                            prev.next = curr.left;
                            prev = curr.left;
                        }
                    }

                    if (curr.right != null)
                    {
                        if (prev == null)
                        {
                            levelHead = curr.right;
                            prev = curr.right;
                        }
                        else
                        {
                            prev.next = curr.right;
                            prev = curr.right;
                        }
                    }

                    curr = curr.next;
                }

                // move to the next level
                curr = levelHead;
                prev = null;
                levelHead = null;
            }

            return root;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node root;
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
