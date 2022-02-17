using System;

namespace _16.Merge2SortedLists
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
        public Node mergeSortedLists(Node list1, Node list2)
        {
            Node temp = new Node(0);
            Node currentNode = temp;
            while (list1 != null && list2 != null)
            {
                if (list1.value < list2.value)
                {
                    currentNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    currentNode.next = list2;
                    list2 = list2.next;
                }
                currentNode = currentNode.next;
            }
            if (list1 != null)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            if (list2 != null)
            {
                currentNode.next = list2;
                list2 = list2.next;
            }
            return temp.next;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);

            Node head2 = new Node(1);
            head2.next = new Node(4);
            head2.next.next = new Node(5);
            Node data = p.mergeSortedLists(head,head2);
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
