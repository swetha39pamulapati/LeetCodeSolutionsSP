using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeSeanPrashad
{
    class Program
    {
        //public class Node
        //{
        //    public int value;
        //    public Node next;
        //    public Node(int val)
        //    {
        //        value = val; next = null;
        //    }
        //}
        //public bool hasCycle(Node head)
        //{
        //    if (head == null)
        //        return false;
        //    Node slow = head;
        //    Node fast = head.next;
        //    while(slow != fast)
        //    {
        //        if (fast == null || fast.next == null)
        //            return false;
        //        slow = slow.next;
        //        fast = fast.next.next;
        //    }

        //    return true;

        //}
        private static string result;

        public static void Print()
        {
            SaySomething();
            Console.WriteLine(result);
        }

        static async Task<string> SaySomething()
        {
            //await Task.Delay release the thread back to the caller and empty string print on the screen
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }
        static void Main(string[] args)
        {

            Program.Print();

            //Node head = new Node(3);
            //head.next = new Node(2);
            //head.next.next = new Node(0);
            //head.next.next.next = new Node(-4);
            //head.next.next.next.next = head.next;
            //Node currentNode = head;
            //Program p = new Program();
            //bool data = p.hasCycle(head);
            //Console.WriteLine("The list has cycle :" + data);
        }
    }
}
