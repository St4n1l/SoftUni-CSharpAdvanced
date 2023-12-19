using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            Func<int[], int> minFunc = n =>
            {
                int smallestNum = int.MaxValue;
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] < smallestNum)
                    {
                        smallestNum = n[i];
                    }
                }

                return smallestNum;

            };

            Console.WriteLine(minFunc(numbers));
        }
    }
}
