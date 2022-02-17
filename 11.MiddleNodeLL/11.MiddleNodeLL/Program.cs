using System;

namespace _11.MiddleNodeLL
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
        public Node middleNode(Node head)
        {
            if (head == null)
                return null;

            Node fast = head;
           Node slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;

        }


        static void Main(string[] args)
        {
            Program list = new Program();
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next= new Node(6);
            Node currentNode = head;
           Node data =   list.middleNode(head);
            Console.WriteLine(data.value + " ");
            while (data!= null)
            {
                Console.Write( data.value + " ");
                data = data.next;
            }
        }
    }
}
