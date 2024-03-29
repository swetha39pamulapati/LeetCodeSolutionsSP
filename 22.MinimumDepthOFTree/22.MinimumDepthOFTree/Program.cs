﻿using System;

namespace _22.MinimumDepthOFTree
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
        public static int MinDepth(Node root)
        {
            //if (root == null)
            //    return 0;
            //if (root.left == null && root.right == null)
            //    return 1;
            //int left = root.left != null ? MinDepth(root.left) : int.MaxValue;
            //int right = root.right != null ? MinDepth(root.right) : int.MaxValue;
            //return Math.Min(left, right) + 1;
            if (root == null) return 0;
            if (root.left == null)
                return MinDepth(root.right) + 1;
            if (root.right == null)
                return MinDepth(root.left) + 1;
            var lefttreeDepth = MinDepth(root.left);
            var rigttreeDepth = MinDepth(root.right);
            return Math.Min(lefttreeDepth, rigttreeDepth) + 1;
        }
        static void Main(string[] args)

        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(9);
            root.right = newNode(20);
            //root.left.left = newNode(3);
            //root.left.right = newNode(5);
            root.right.left = newNode(15);
            root.right.right = newNode(7);
            Console.WriteLine("Min Depth : ");

            Console.WriteLine(MinDepth(root));
        }
    }
}
