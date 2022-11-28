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
            Node head = root;
            while(head!= null)
            {
                Node dummy = new Node();
                Node temp = dummy;
                while(head!= null)
                {
                    if(head.left!= null)
                    {
                        temp.next = head.left;
                        temp = temp.next;
                    }
                    if (head.right != null)
                    {
                        temp.next = head.right;
                        temp = temp.next;
                    }
                    head = head.next;
                }
                //next level
                head = dummy.next;
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
