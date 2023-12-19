using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;
            Action<int[]> print = n =>
            {
                Console.WriteLine(String.Join(' ', n));
            };

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                command = Console.ReadLine();
            }
        }
    }
}
