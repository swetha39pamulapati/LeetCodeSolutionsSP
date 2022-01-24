using System;

namespace _86.RotateList
{
    //https://www.youtube.com/watch?v=UcGtPs2LE_c
    class Program
    {
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
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return head;
            int length = 1;
            var tail = head;
            while (tail.next != null)
            {
                length++;
                tail = tail.next;
            }
            k = k % length; //to avoid rotations of multiples of K  if length of elements is 5
            // and we have to roate it K = 10, then the result will be same as the given list.
            // So in order to avoid the rotations, check it before and return head
            if (length == 0)
            {
                return head;
            }
            if (k == 0)
            {
                return head;
            }
            var current = head;
            for( int  i = 0; i< length-k-1; i++)
            {
                current = current.next;
            }
            ListNode newhead = current.next;
            current.next = null;
            tail.next = head;
            return newhead;
        }
    
    static void Main(string[] args)
        {
            ListNode head = new ListNode(0);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            Program p = new Program();
            ListNode result = p.RotateRight(head,4);
            Console.WriteLine(result);
        }
    }
}
