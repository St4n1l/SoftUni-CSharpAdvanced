using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }

                return result;
            };

            Func<List<int>, List<int>> remove = numbers =>
            {
                List<int> result = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % n != 0)
                    {
                        result.Add(numbers[i]);
                    }
                }

                return result;
            };

            numbers = reverse(numbers);
            numbers = remove(numbers);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
