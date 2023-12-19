using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queueOfClients = new Queue<int>(orders);
            Console.WriteLine(queueOfClients.Max());

            while (quantityOfFood != 0 && queueOfClients.Count != 0)
            {
                int currentOrder = queueOfClients.Peek();
                if (quantityOfFood >= currentOrder)
                {
                    quantityOfFood -= currentOrder;
                    queueOfClients.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queueOfClients.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(' ', queueOfClients)}");
            }




        }
    }
}