using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            string text = String.Empty;

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();

                if(command[0] == "1")
                {
                    stack.Push(text);
                    text += command[1];
                }
                else if(command[0] == "2")
                {
                    int index = int.Parse(command[1]);
                    stack.Push(text);
                    text = text.Substring(0, text.Length - index);
                }
                else if(command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if(command[0] == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
