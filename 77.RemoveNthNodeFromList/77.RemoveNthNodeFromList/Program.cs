﻿using System;

namespace _77.RemoveNthNodeFromList
{
   // https://www.youtube.com/watch?v=XtYEEvrhemI
    class Program
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int val)
            {
                value = val; next = null;
            }
        }
        public Node RemoveNthFromEnd(Node head, int n)
        {
            Node dummyHead = new Node(0);
            dummyHead.next = head;
            Node slow = dummyHead;
            Node fast = dummyHead;
            for(int i = 1; i<=n+1; i++)
            {
                fast = fast.next;
            }
            while(fast!= null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;// removes the node
            return dummyHead.next;
        }
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            Program p = new Program();
            Node data = p.RemoveNthFromEnd(head, 2);
            Console.WriteLine(data);
        }
    }
}
