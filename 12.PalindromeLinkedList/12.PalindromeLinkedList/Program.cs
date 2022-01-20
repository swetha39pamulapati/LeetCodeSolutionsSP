using System;

namespace _12.PalindromeLinkedList
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
        public bool palindromeLinkedList(Node head)
        {
            if (head == null || head.next == null)
                return true;
            Node slow = head;
            Node fast = head;
            while(fast!= null && fast.next!= null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            //if (fast != null)
            //    slow = slow.next;

            slow = reverse(slow);
            fast = head;
            while(slow!= null)
            {
                if(fast.value != slow.value)
                    return false;
                fast = fast.next;
                slow = slow.next;
            }
            return true;
        }
        private Node reverse(Node head)
        {
            Node prev = null;
            Node next = null;
            Node curr = head;
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
            Program list = new Program();
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(3);
            head.next.next.next.next = new Node(2);
            head.next.next.next.next.next = new Node(1);
             bool data = list.palindromeLinkedList(head);
           
                Console.Write("The given list is palindrome :  "+data);
                
        }
    }
}
