using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                box.Item.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box.Count(double.Parse(Console.ReadLine())));
        }
    }
}
