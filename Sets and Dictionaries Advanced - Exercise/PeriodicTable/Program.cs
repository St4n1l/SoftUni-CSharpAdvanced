using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemElements = new SortedSet<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] currentElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                chemElements.UnionWith(currentElements);
            }

            Console.WriteLine(string.Join(' ', chemElements));
        }
    }
}
