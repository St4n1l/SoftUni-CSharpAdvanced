using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = new List<string>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                listOfString.Add(Console.ReadLine());
            }

            int[] indeces = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Swap(listOfString, indeces[0], indeces[1]);
        }

        public static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            (list[firstIndex], list[secondIndex]) = (list[secondIndex], list[firstIndex]);
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
