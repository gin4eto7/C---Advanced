using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int count = 0;
            int index = 0;
            for (int i = 0; i < value; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }
            int total = 0;
            while (true)
            {
                string curr = queue.Dequeue();
                int[] currValue = curr.Split().Select(int.Parse).ToArray();
                int currQuantity = currValue[0];
                int currDistance = currValue[1];

                total += currQuantity;

                if(total >= currDistance)
                {
                    total -= currDistance;
                    count++;
                }
                else
                {
                    total = 0;
                    index++;
                    count = 0;
                }

                queue.Enqueue(curr);

                if(count == queue.Count)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
