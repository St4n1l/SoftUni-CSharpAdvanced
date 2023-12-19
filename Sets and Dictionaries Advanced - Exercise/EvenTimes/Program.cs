using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberByCount = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numberByCount.ContainsKey(currentNumber))
                {
                    numberByCount.Add(currentNumber, 0);
                }

                numberByCount[currentNumber]++;
            }

            Console.WriteLine(numberByCount.Single(n => n.Value % 2 == 0).Key);
        }
    }
}
