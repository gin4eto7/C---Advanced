using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            int sum = 0;

            while (queue.Count > 0)
            {
                if (queue.Peek() + sum > quantityFood)
                {
                    Console.WriteLine(String.Join(" ", $"Orders left: {queue.Dequeue()}"));
                    return;
                }
                else
                {
                    sum += queue.Dequeue();
                }

            }
            Console.WriteLine($"Orders complete");
        }
    }
}
