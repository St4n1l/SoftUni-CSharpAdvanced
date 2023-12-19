using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queue = new Queue<string>(firstSongs);

            while (queue.Any())
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    StringBuilder songToAdd = new StringBuilder();
                    for (int i = 1; i < command.Length; i++)
                    {
                        songToAdd.Append(command[i] + " ");
                    }

                    if (queue.Contains(songToAdd.ToString().TrimEnd()))
                    {
                        Console.WriteLine($"{songToAdd.ToString().TrimEnd()} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songToAdd.ToString().TrimEnd());
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
