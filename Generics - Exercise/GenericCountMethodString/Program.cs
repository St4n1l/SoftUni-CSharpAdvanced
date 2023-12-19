using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Item.Add(Console.ReadLine());
            }

            Console.WriteLine(box.Count(Console.ReadLine()));
        }

    }

}
