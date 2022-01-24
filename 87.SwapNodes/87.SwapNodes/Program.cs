using System;

namespace _87.SwapNodes
{
    class Program
    {
        //https://www.youtube.com/watch?v=-xwX521Ija4
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode SwapPairs(ListNode head)
        {
            ListNode temp = new ListNode(0);
            temp.next = head;
            ListNode current = temp;
            while (current.next != null && current.next.next != null)
            {
                ListNode firstNode = current.next;
                ListNode secondNode = current.next.next;
                firstNode.next = secondNode.next;
                current.next = secondNode;
                current.next.next = firstNode;
                current = current.next.next;
            }
            return temp.next;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            Program p = new Program();
            ListNode result = p.SwapPairs(head);
            Console.WriteLine(result);
        }
    }
}
