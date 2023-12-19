using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string[] command = Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

            List<int> listOfElements = new List<int>();
            listOfElements = command.Skip(1).Select(int.Parse).ToList();

            foreach (var element in listOfElements)
            {
                stack.Push(element);
            }

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command[0] == "Push")
                {
                    stack.Push(int.Parse(command[1]));
                }
            }

            foreach (var el in stack)
            {
                Console.WriteLine(el);
            }

            foreach (var el in stack)
            {
                Console.WriteLine(el);
            }
        }
    }
}
