using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                Box<string> newBox = new Box<string>(input);
                boxes.Add(newBox);
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
