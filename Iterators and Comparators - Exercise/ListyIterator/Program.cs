using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList =
                Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> listy = new ListyIterator<string>(newList);

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                if (command[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command[0] == "Print")
                {
                    listy.Print();
                }
                else if (command[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
