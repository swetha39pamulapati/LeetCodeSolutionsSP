using System;

namespace _85.ReverseLinkedList2
{
    //https://www.youtube.com/watch?v=GSJuwQzKSnI
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
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode curr = head, prev = null;
            //getting left -1 nodes
            for (int i = 0; i < left - 1 && curr != null; i++)
            {
                prev = curr;
                curr = curr.next;
            }

            ListNode endOfLeftPart = prev;
            ListNode endOfrightPart = curr;
            ListNode next = null;
            //reverse nodes from left to right
            for (int i = 0; i < right - left + 1 && curr != null; i++)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            if (endOfLeftPart != null)
            {
                endOfLeftPart.next = prev;
            }
            else
            {
                head = prev;
            }
            endOfrightPart.next = curr;

            return head;
            //if (head == null)
            //    return null;
            //ListNode prev = null;
            //ListNode currentNode = head;
            //while (left > 1)
            //{
            //    prev = currentNode;
            //    currentNode = currentNode.next;
            //    left--;
            //    right--;
            //}
            //ListNode connection = prev;
            //ListNode tail = currentNode;
            //while (right > 0)
            //{
            //    ListNode nextNode = currentNode.next;
            //    currentNode.next = prev;
            //    prev = currentNode;
            //    currentNode = nextNode;
            //    right--;
            //}
            //if (connection != null)
            //{
            //    connection.next = prev;
            //}
            //else
            //    head = prev;
            //tail.next = currentNode;
            //return head;

        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
             head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next= new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            Program p = new Program();
           ListNode result =  p.ReverseBetween(head,2,4);
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
