using System;

namespace GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
