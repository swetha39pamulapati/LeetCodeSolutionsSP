using System;
using System.Collections.Generic;
using System.Linq;

namespace _146.MergeKsortedLists
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;
            if (lists.Length == 1)
                return lists[0];

            var dict = new Dictionary<int, List<ListNode>>();

            foreach (var list in lists)
            {
                var cur = list;
                while (cur != null)
                {
                    if (dict.ContainsKey(cur.val))
                        dict[cur.val].Add(cur);
                    else
                        dict.Add(cur.val, new List<ListNode>() { cur });

                    cur = cur.next;
                }
            }

            var sorted = dict.OrderBy(d => d.Key).ToArray();
            ListNode head = null, curNode = null;
            foreach (var nodes in sorted)
            {
                foreach (var node in nodes.Value)
                {
                    if (head == null)
                    {
                        head = node;
                        curNode = head;
                    }
                    else
                    {
                        curNode.next = node;
                        curNode = curNode.next;
                    }
                }
            }

            if (curNode != null)
                curNode.next = null;

            return head;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ListNode head = new ListNode(1);
            head.next = new ListNode(4);
            head.next.next = new ListNode(5);

            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(3);
            head1.next.next = new ListNode(4);

            ListNode head2 = new ListNode(2);
            head2.next = new ListNode(6);
            ListNode[] data = new ListNode[3];
            data[0] = head;
            data[1] = head1;
            data[2] = head2;
          ListNode result =  p.MergeKLists(data);
            Console.WriteLine(result);
        }
    }
}
