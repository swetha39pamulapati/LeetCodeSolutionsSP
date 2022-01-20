using System;

namespace _13.RemoveValueLinkedList
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
        public Node removeValue(Node head, int val)
        {
            var item = head;
            while (item != null && item.value == val)
                item = item.next;
           Node result = item;

            while (item != null)
            {
                while (item.next != null && item.next.value == val)
                    item.next = item.next.next;
                item = item.next;
            }
            return result;


        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next = new Node(6);
            Node currentNode = head;
            Node data = p.removeValue(head,4);
            if (data == null)
                Console.WriteLine("The list is empty");
            else { 
            while (data != null)
            {
                Console.WriteLine(data.value);
                data = data.next;
            }
            }

        }
    }
}
