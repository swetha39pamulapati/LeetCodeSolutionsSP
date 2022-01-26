using System;

namespace _106.FruitIntoBaskets
{
    class Program
    {
        public int TotalFruit(int[] fruits)
        {
            int lastFruit = -1;
            int secondLastFruit = -1;
            int lastFruitCount = 0;
            int currentMax = 0;
            int max = 0;
            foreach(int fruit in fruits)
            {
                if(fruit == lastFruit || fruit == secondLastFruit)//if you see same 1st and second fruit;
                {
                    currentMax += 1;
                }
                else
                {
                    //differnt fruit, we will remove the 1st fruit count and take last fruit count and next one;
                    currentMax = lastFruitCount + 1; 
                }
                if (fruit == lastFruit)
                    lastFruitCount++;
                else
                    lastFruitCount = 1; //new fruit
                if (fruit != lastFruit)
                {
                    secondLastFruit = lastFruit;
                    lastFruit = fruit;
                }
                max = Math.Max(currentMax, max);
            }
            return max;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] fruits = {1, 2, 1};
            int data = p.TotalFruit(fruits);

            Console.WriteLine(data);
        }
    }
}
