using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSeanPrashad
{
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
        public bool hasCycle(Node head)
        {
            if (head == null)
                return false;
            Node slow = head;
            Node fast = head.next;
            while(slow != fast)
            {
                if (fast == null || fast.next == null)
                    return false;
                slow = slow.next;
                fast = fast.next.next;
            }
           
            return true;

        }
            static void Main(string[] args)
        {
            Node head = new Node(3);
            head.next = new Node(2);
            head.next.next = new Node(0);
            head.next.next.next = new Node(-4);
            head.next.next.next.next = head.next;
            Node currentNode = head;
            Program p = new Program();
            bool data = p.hasCycle(head);
            Console.WriteLine("The list has cycle :" + data);
        }
    }
}
