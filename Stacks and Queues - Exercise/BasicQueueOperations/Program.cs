using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < arguments[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (queue.Contains(arguments[2]))
            {
                Console.WriteLine("true");
                return;
            }

            Console.WriteLine(queue.Min());
        }
    }
}