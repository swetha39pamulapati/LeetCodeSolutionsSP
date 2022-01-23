using System;

namespace _79.SortList
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
        public Node SortList(Node head)
        {
            if (head == null || head.next == null) return head;
            Node temp = head;
            Node slow = head;
            Node fast = head;
            while(fast!= null && fast.next!= null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            temp.next = null;

            Node left = SortList(head);
            Node right = SortList(slow);

            return mergedList(left, right);
        }
        private Node mergedList(Node l1, Node l2)
        {
            Node sortedTemp = new Node(0);
            Node currentNode = sortedTemp;
            while(l1 != null && l2!= null)
            {
                if (l1.value < l2.value)
                {
                    currentNode.next = l1;
                    l1 = l1.next;

                }
                else
                {
                    currentNode.next = l2;
                    l2 = l2.next;
                }
                currentNode = currentNode.next;
            }
            if(l1!= null)
            {
                currentNode.next = l1;
                l1 = l1.next;

            }
            if (l2 != null)
            {
                currentNode.next = l2;
                l2 = l2.next;

            }
            return sortedTemp.next;
        }
        static void Main(string[] args)
        {
            Node head = new Node(4);
            head.next = new Node(2);
            head.next.next = new Node(1);
            head.next.next.next = new Node(3);
            Program p = new Program();
            Node result = p.SortList(head);
            Console.WriteLine(result);
        }
    }
}
