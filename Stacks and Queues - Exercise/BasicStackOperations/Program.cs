using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nsx = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < int.Parse(nsx[0]); i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < int.Parse(nsx[1]); i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (stack.Contains(int.Parse(nsx[2])))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                int smallestNum = int.MaxValue;
                for (int i = 0; i < stack.Count; i++)
                {
                    int currentNum = stack.Pop();
                    if (currentNum < smallestNum)
                    {
                        smallestNum = currentNum;
                    }
                }

                Console.WriteLine(smallestNum);
            }

        }
    }
}
