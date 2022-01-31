using System;

namespace _145.ReverseNodesKGroup
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
    class Program
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
                return head;

            ListNode dummy = new ListNode();
            dummy.next = head;
            ListNode prev = dummy;
            ListNode curr = dummy;
            ListNode next = null;

            while (curr != null)
            {
                for (int i = 0; i < k && curr != null; i++)
                    curr = curr.next;

                if (curr == null)
                    break;

                next = curr.next;
                curr.next = null;

                ListNode start = prev.next;
                prev.next = reverse(start);
                start.next = next;

                prev = start;
                curr = start;
            }

            return dummy.next;
        }

        private ListNode reverse(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode prev = null;
            ListNode next = null;
            ListNode curr = head;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ListNode result =  p.ReverseKGroup(head, 2);
            Console.WriteLine(result);
        }
    }
}
