using System;

namespace _19.SmallestletterGreaterThanTarget
{
    class Program
    {
        public static char findGreatestChar(char[] letters, char target)
        {
            //for (int i = 0; i < letters.Length; i++)
            //{

            //    if (target < letters[i])
            //    {
            //        return letters[i];
            //    }
            //    if (target >= letters[letters.Length - 1])
            //    {
            //        return letters[0];
            //    }

            //}
            //return target;

            //Binary Search
            int l = 0, r = letters.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (letters[mid] <= target)
                    l = mid + 1;
                else
                    r = mid - 1;
            }

            if (l >= letters.Length) l = 0;
            return letters[l];


        }
        static void Main(string[] args)
        {
            char[] data = { 'c', 'd', 'f' };
          char result =   findGreatestChar(data,'a');
            Console.WriteLine(result);
        }
    }
}
