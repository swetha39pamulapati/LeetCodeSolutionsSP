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
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            Node newHead = new Node(0);
            var newList = newHead;
            while (list1!= null  && list2 != null)
            {
                if(list1.value >= list2.value)
                {
                    newList.next = list2;
                    list2 = list2.next;

                }
                else
                {
                    newList.next = list1;
                    list1 = list1.next;
                }
                newList = newList.next;
            }
            //Add Remaining elements
            if (list1 != null) 
                newList.next = list1;
            if (list2 != null) 
                newList.next = list2;
            return newHead.next;
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
