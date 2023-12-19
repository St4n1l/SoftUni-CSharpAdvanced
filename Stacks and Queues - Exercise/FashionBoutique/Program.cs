using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(clothes);
            int racksNeeded = 0;
            int valueOfClothes = 0;
            while (clothesStack.Count != 0)
            {
                int currentGarment = clothesStack.Peek();
                if (valueOfClothes + currentGarment == rackCapacity)
                {
                    racksNeeded++;
                    clothesStack.Pop();
                    valueOfClothes = 0;
                    continue;
                }
                else if (valueOfClothes + currentGarment > rackCapacity)
                {
                    racksNeeded++;
                    valueOfClothes = 0;
                    continue;
                }
                else if (valueOfClothes + currentGarment < rackCapacity)
                {
                    valueOfClothes += currentGarment;
                    clothesStack.Pop();
                }

                if (clothesStack.Count == 0)
                {
                    racksNeeded++;
                }
            }

            Console.WriteLine(racksNeeded);
        }
    }
}