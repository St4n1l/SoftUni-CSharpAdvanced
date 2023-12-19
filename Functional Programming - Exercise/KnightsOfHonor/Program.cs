using System;
using System.Linq;
using System.Threading.Channels;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> print = p =>
            {
                foreach (var person in p)
                {
                    Console.WriteLine($"Sir {person}");
                }
            };
            print(people);
        }
    }
}
