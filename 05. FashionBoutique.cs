using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothesInBox);
            int sum = 0;
            int count = 0;

            while (stack.Count > 0)
            {
                if(stack.Peek() + sum > capacity)
                {
                    sum = 0;
                    count++;
                }
                else
                {
                    sum += stack.Pop();
                    
                }
            }
            if(sum != 0)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
