using System;

namespace _129.LCAOfBinaryTree
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
        public static Node LCAOfBinaryTree(Node root, Node p, Node q)
        {
            //if (root == null)
            //    return null;
            //if (p.val < root.val && q.val < root.val)
            //{
            //    return LCAOfBinaryTree(root.left, p, q);


            //}
            //else if (p.val > root.val && q.val > root.val)
            //    return LCAOfBinaryTree(root.right, p, q);
            //return root;


            if (root == null)
            {
                return root;
            }
            //// if any one of p or q is root itself. root is itself ancestor to itself  
            if (root.val == p.val || root.val == q.val)
            {
                return root;
            }

            var left = LCAOfBinaryTree(root.left, p, q);
            var right = LCAOfBinaryTree(root.right, p, q);
            // This means one of p and q is on right side and other one is on left side 
            // so ancestor in that case will be root
            if (left != null && right != null)
            {
                return root;
            }
            // We have already checked for both the condition above 
            // This means we have found both p and q on left subtree, so return left
            if (left != null)
            {
                return left;
            }
            // We have already checked for both the condition above 
            // This means we have found both p and q on right subtree, so return right
            if (right != null)
            {
                return right;
            }

            // if not found just return null
            return null;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(3);
            root.left = newNode(5);
            root.right = newNode(1);
            root.left.left = newNode(6);
            root.left.right = newNode(2);
            root.right.left = newNode(0);
            root.right.right = newNode(8);
            root.left.right.left = newNode(7);
            root.left.right.right = newNode(4);
            Node result = LCAOfBinaryTree(root, newNode(5), newNode(1));
            Console.WriteLine(result.val);
        }
    }
}
