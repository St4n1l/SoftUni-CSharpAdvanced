using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            bool isEven = Console.ReadLine() == "even";

            Predicate<int> even = n => n % 2 == 0;
            Predicate<int> odd = n => n % 2 != 0;

            if (isEven)
            {
                Console.WriteLine(string.Join(' ', numbers.FindAll(even)));
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers.FindAll(odd)));
                numbers.FindAll(odd);
            }

        }
    }
}
