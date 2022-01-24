using System;

namespace _88.OddEvenLinkedList
{
   // https://www.youtube.com/watch?v=C_LA6SOwVTM
   //Seperate odd number heads and even number head and in the end attach both;
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
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead; //attach odd tail to even head;
            return head;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            Program p = new Program();
            ListNode result = p.OddEvenList(head);
            Console.WriteLine(result);
        }
    }
}
