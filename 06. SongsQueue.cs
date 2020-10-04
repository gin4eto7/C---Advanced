using System;
using System.Collections.Generic;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                queue.Enqueue(songs[i]);
            }

            string commands = Console.ReadLine();
            while (queue.Count > 0)
            {

                if (commands.Contains("Add"))
                {
                    string song = commands.Substring(4, commands.Length - 4);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {

                        queue.Enqueue(song);
                    }
                }
                else if (commands.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
                else if (commands.Contains("Play"))
                {
                    if (queue.Count > 0)
                    {
                        queue.Dequeue();
                    }

                }
                commands = Console.ReadLine();

            }

            if (queue.Count == 0)
            {

                Console.WriteLine("No more songs!");

            }
        }
    }
}
