using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charByOccurence = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charByOccurence.ContainsKey(text[i]))
                {
                    charByOccurence.Add(text[i], 0);
                }

                charByOccurence[text[i]]++;
            }

            foreach (var character in charByOccurence)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}