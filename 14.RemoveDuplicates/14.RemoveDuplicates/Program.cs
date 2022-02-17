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
            Node currentNode = head;
            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.next.value == currentNode.value)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                    currentNode = currentNode.next;
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
