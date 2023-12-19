using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> coloursByClothes =
                new Dictionary<string, Dictionary<string, int>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] currentColourAndClothes = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (!coloursByClothes.ContainsKey(currentColourAndClothes[0]))
                {
                    coloursByClothes.Add(currentColourAndClothes[0], new Dictionary<string, int>());
                }

                for (int j = 1; j < currentColourAndClothes.Length; j++)
                {
                    if (!coloursByClothes[currentColourAndClothes[0]].ContainsKey(currentColourAndClothes[j]))
                    {
                        coloursByClothes[currentColourAndClothes[0]].Add(currentColourAndClothes[j], 0);
                    }

                    coloursByClothes[currentColourAndClothes[0]][currentColourAndClothes[j]]++;
                }

            }

            string[] wantedGarment = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var colour in coloursByClothes)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var garment in colour.Value)
                {
                    string print = $"* {garment.Key} - {garment.Value}";
                    if (colour.Key == wantedGarment[0] && garment.Key == wantedGarment[1])
                    {
                        print += $" (found!)";
                    }

                    Console.WriteLine(print);
                }
            }
        }
    }
}
