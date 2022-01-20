using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        public bool containsDuplicate(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
                return false;
            var containsDup = new HashSet<int>();
            foreach (var item in arr)
            {
                if (containsDup.Contains(item))
                {
                    Console.WriteLine(item + " is present in the list");
                    return true;
                }
                else
                {
                   
                    containsDup.Add(item);
                }
                
            }
            Console.WriteLine("The list does not contain duplicate value");
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] array = { 1, 2, 1, 3, 4 };
            p.containsDuplicate(array);

        }
    }
}
