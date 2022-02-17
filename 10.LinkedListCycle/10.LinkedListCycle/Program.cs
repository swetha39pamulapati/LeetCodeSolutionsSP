using System;

namespace _10.LinkedListCycle
{
    class Program
    {
      public  class Node
        {
            public int value;
            public Node next;
            public Node(int val)
            {
                value = val; next = null;
            }
        }
        public class singlyLinkedList
        {
            public Node head;
            public singlyLinkedList()
            {
                head = null;
            }
            public void InsertEmptyList(int data)
            {
                Node newNode = new Node(data);
                head = newNode;
            }
            public bool hasCycle(Node head)
            {
                if (head == null || head.next == null)
                    return false;
                Node slow = head;
                Node fast = head.next;

                while (slow != fast)
                {
                    if (fast == null || fast.next == null)
                        return false;
                    slow = slow.next;
                    fast = fast.next.next;

                }
                return true;
            }
            public void InsertEnd(int val)
            {
                Node p = head;
                Node newNode = new Node(val);
                if (head == null) {
                    head = newNode;
                    return;
                }
                while (p.next != null)
                    p = p.next;
                p.next = newNode;
            }
            public void printList()
            {
                Node p;
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                p = head;
                while (p != null)
                {
                    Console.WriteLine(p.value);
                    p = p.next;
                }
            }
        }
        static void Main(string[] args)
        {
            singlyLinkedList list = new singlyLinkedList();
            list.InsertEmptyList(3);
            list.InsertEnd(2);
            list.InsertEnd(0);
            list.InsertEnd(-4);
            list.printList();
            Node head = new Node(3);
            head.next = new Node(2);
            head.next.next = new Node(0);
            head.next.next.next = new Node(-4);
            head.next.next.next.next = head.next;
            Node currentNode = head;
           bool data = list.hasCycle(head);
            Console.WriteLine("The list has cycle :" + data);
        }
    }
}
