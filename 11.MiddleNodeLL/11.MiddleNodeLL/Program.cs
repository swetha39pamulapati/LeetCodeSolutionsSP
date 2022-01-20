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
            Node start = head;
            Node end = head;
            if(start == null || end == null)
            {
                return null;
            }
            while (end!= null && end.next != null)
            {
                start = start.next;
                end = end.next.next;
            }
            return start;

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
            while (data!= null)
            {
                Console.Write( data.value + " ");
                data = data.next;
            }
        }
    }
}
