using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> doublePeopleWithLenght = p => p.Length == int.Parse(command[2]);
            Predicate<string> doublePeopleStartingWith = p => p.StartsWith(command[2]);
            Predicate<string> doublePeopleEndingWith = p => p.EndsWith(command[2]);

            while (command[0] != "Party!")
            {
                string filter = command[1];
                string value = command[2];

                if (command[0] == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else if (command[0] == "Double")
                {
                    int index = people.FindIndex((GetPredicate(filter, value)));
                    if (index >= 0)
                    {
                        people.InsertRange(index, people.FindAll(GetPredicate(filter, value)));
                    }

                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            if (people.Count == 0)
            {
                Console.WriteLine($"Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }


        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Length":
                    return p => p.Length == int.Parse(value);
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                default:
                    return null;
            }
        }
    }
}
