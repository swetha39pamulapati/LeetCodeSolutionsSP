using System;

namespace _14.RemoveDuplicates
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
        public Node removeDuplicates( Node head)
        {
            if (head == null || head.next == null)
                return head;
            Node p1 = head;
            Node p2 = head.next;
            while(p2 != null)
            {
                if(p1.value == p2.value)
                {
                    p1.next = p2.next;
                    p2.next = null;
                    p2 = p1.next;
                }
                else
                {
                    p1 = p2;
                    p2 = (p2 != null) ? p2.next : null;
                }
            }
            return head;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node head = new Node(1);
            head.next = new Node(1);
            head.next.next = new Node(2);
            head.next.next.next = new Node(3);
            //head.next.next.next.next = new Node(5);
            //head.next.next.next.next.next = new Node(6);
            Node data = p.removeDuplicates(head);
            if (data == null)
                Console.WriteLine("The list is empty");
            else
            {
                while (data != null)
                {
                    Console.WriteLine(data.value);
                    data = data.next;
                }
            }
            }
    }
}
