using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int[] numbers = Enumerable.Range(1, range).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var devider in deviders)
            {
                Predicate<int> currentPredicate = n => n % devider == 0;
                predicates.Add(currentPredicate);
            }


            List<int> result = new List<int>();
            foreach (var num in numbers)
            {
                bool isValid = false;
                foreach (var predicate in predicates)
                {
                    if (predicate(num))
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                }

                if (isValid)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(' ', result));

        }
    }
}
