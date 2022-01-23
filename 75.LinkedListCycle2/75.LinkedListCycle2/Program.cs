using System;
using System.Collections.Generic;

namespace _75.LinkedListCycle2
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
        public class singlyLinkedList
        {
            public Node head;
            public singlyLinkedList()
            {
                head = null;
            }
            public Node DetectCycle(Node head)
            {
                if (head == null) return null;

                var slow = head;
                var fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;

                    if (slow == fast) break;
                }

                if (fast == null || fast.next == null) return null;

                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                return fast;

            }

        }
            static void Main(string[] args)
        {
            singlyLinkedList list = new singlyLinkedList();
            Node head = new Node(3);
            head.next = new Node(2);
            head.next.next = new Node(0);
            head.next.next.next = new Node(-4);
            head.next.next.next.next = head.next;
            Node data = list.DetectCycle(head);
            Console.WriteLine("The list has cycle at value:" + data.value);
        }
    }
}
