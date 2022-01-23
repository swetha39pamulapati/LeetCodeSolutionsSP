using System;

namespace _78.ReorderList
{
    class Program
    {
        //https://www.youtube.com/watch?v=xRYPjDMSUFw&t=60s
        //The idea is to divide the list into 2,  and reverse the second list and join the values of 1st and 2nd list.
        //1->2->3->4  =>  1->2-> null,  3->4->null;
        //1->3->2->4
        public class Node
        {
            public int value;
            public Node next;
            public Node(int val)
            {
                value = val; next = null;
            }
        }
        public void orderlist(Node head)
        {
            if (head == null || head.next == null)
                return;
            //head of 1st half
            Node l1 = head;
            //head of 2nd half
            Node slow = head;
            //tail of 2nd half
            Node fast = head;
            //tail of 1st half
            Node temp = null;
            while (fast != null && fast.next != null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            temp.next = null; //makes the middle's next to null;
            Node l2 = reverse(slow);
            merge(l1, l2);
        }
        private void merge(Node l1, Node l2)
        {
            while (l1 != null)
            {
                Node l1Next = l1.next;
                Node l2Next = l2.next;
                l1.next = l2;
                if (l1Next == null)
                    break;
                l2.next = l1Next;
                l1 = l1Next;
                l2 = l2Next;
            }


        }
        public Node reverse(Node head)
        {
            Node prev = null;
            Node currentNode = head;
            while(currentNode != null)
            {
                Node nextNode = currentNode.next;
                currentNode.next = prev;
                prev = currentNode;
                currentNode = nextNode;
            }
            return prev;
        }
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(4);
            head.next.next.next = new Node(4);
            Program p = new Program();
           p.orderlist(head);
            //Console.WriteLine(data);
        }
    }
}
