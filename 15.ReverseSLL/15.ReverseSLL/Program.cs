using System;

namespace _15.ReverseSLL
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
        public Node ReverseList(Node head)
        {
            //Node prev = null;
            //while(head != null)
            //{
            //    Node next_node = head.next;
            //    head.next = prev;
            //    prev = head;
            //    head =next_node;
            //}
            //return prev;
            if (head == null)
                return head;
            Node tempNode = head;
            Node prevNode = head;
            Node currentNode = head.next;
            prevNode.next = null;
            while (currentNode != null)
            {
                tempNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = tempNode;
            }
            return prevNode;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node head = new Node(1);
            head.next = new Node(4);
            head.next.next = new Node(2);
            head.next.next.next = new Node(3);
          Node data=  p.ReverseList(head);
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
