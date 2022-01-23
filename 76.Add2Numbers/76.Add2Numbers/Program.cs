using System;

namespace _76.Add2Numbers
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
        public Node AddTwoNumbers(Node l1, Node l2)
        {
            int carry = 0;
            Node p = new Node(0);
            Node pre = p;

            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = (l1 == null ? 0 : l1.value) + (l2 == null ? 0 : l2.value) + carry;
                carry = sum < 10 ? 0 : 1;
                pre.next = new Node(sum % 10);
                pre = pre.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            return p.next;
        }
        static void Main(string[] args)
        {
            Node head = new Node(2);
            head.next = new Node(4);
            head.next.next = new Node(3);

            Node head1 = new Node(5);
            head1.next = new Node(6);
            head1.next.next = new Node(4);
            Program p = new Program();
            Node result = p.AddTwoNumbers(head, head1);
            Console.WriteLine(result);
        }
    }
}
