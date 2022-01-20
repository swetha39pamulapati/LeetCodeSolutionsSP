using System;
using System.Collections.Generic;

namespace _21.CreateAverageLevelTree
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
        public static IList<double> averageOfLevels(Node root)
        {

            List<double> res = new List<double>();
            if (root == null)
                return res;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                double sum = 0;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    sum += curr.val;

                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
                res.Add(sum / size);
            }
                return res;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(4);
            root.left = newNode(2);
            root.right = newNode(9);
            root.left.left = newNode(3);
            root.left.right = newNode(5);
            root.right.right = newNode(7);
            Console.WriteLine("Averages of levels : ");
            Console.Write("[");
            IList<double> result =  averageOfLevels(root);
            if (result.Count != 0)
            {
                for (int i = 0; i < result.Count; i++)
                    Console.Write(result[i] + " ,");
            }
            Console.WriteLine("]");
        }
    }
}
