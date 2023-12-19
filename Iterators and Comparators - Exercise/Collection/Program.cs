using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
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
                switch (command[0])
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "PrintAll":
                        listy.PrintAll();
                        break;
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
