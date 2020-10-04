using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            for (int i = 0; i < input.Length / 2; i++)
            {
                stack1.Push(input[i]);
            }

            for (int i = input.Length - 1; i > input.Length / 2 - 1; i--)
            {
                stack2.Push(input[i]);
            }

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                if ((stack1.Peek() == '(' && stack2.Peek() == ')')
                    || (stack1.Peek() == '[' && stack2.Peek() == ']')
                    || (stack1.Peek() == '{' && stack2.Peek() == '}'))
                {
                    stack1.Pop();
                    stack2.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }

            }

            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}