using System;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            Predicate<string> filter = w => w.Length <= lenght;
            Console.WriteLine(string.Join(Environment.NewLine, Array.FindAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), filter)));
        }
    }
}