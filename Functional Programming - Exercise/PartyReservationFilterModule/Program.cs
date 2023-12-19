using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();


            string[] command = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Print")
            {
                string filter = command[1];
                string value = command[2];


                if (command[0] == "Add filter" && !filters.ContainsKey(filter + value))
                {
                    filters.Add(command[1] + command[2], GetPredicate(filter, value));
                }
                else
                {
                    filters.Remove(command[1] + command[2]);
                }

                command = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));

        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return p => p.StartsWith(value);
                    break;
                case "Ends with":
                    return p => p.EndsWith(value);
                    break;
                case "Lenght":
                    return p => p.Length == int.Parse(value);
                    break;
                case "Contains":
                    return p => p.Contains(value);
                default:
                    return null;

            }
        }
    }


}
