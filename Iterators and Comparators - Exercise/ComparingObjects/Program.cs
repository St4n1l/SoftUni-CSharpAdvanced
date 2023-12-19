using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                Person newPerson = new Person(command[0],int.Parse(command[1]),command[2]);
                people.Add(newPerson);

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }


            Person personToCompare = people[int.Parse(Console.ReadLine()) - 1];
            int matchingPeople = 0;
            int differentPeople = 0;
            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    matchingPeople++;
                }
                else
                {
                    differentPeople++;
                }
            }

            if (matchingPeople == 1) 
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{matchingPeople} {differentPeople} {people.Count}");
            }
        }
    }
}
