using System;
using System.Collections.Generic;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstThreeUpleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string fullName = $"{firstThreeUpleInfo[0]} {firstThreeUpleInfo[1]}";
            string fullTownName = string.Empty;
            if (firstThreeUpleInfo.Length > 4)
            {
                fullTownName = $"{firstThreeUpleInfo[3]} {firstThreeUpleInfo[4]}";
            }
            else
            {
                fullTownName = firstThreeUpleInfo[3];
            }

            ThreeUple<string, string, string> firstThreeUple = new ThreeUple<string, string, string>(fullName, firstThreeUpleInfo[2], fullTownName);

            string[] secondThreeupleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool isDrunk = secondThreeupleInfo[2] == "drunk" ? true : false;
            ThreeUple<string, int, bool> secondThreeUple =
                new ThreeUple<string, int, bool>(secondThreeupleInfo[0], int.Parse(secondThreeupleInfo[1]), isDrunk);

            string[] thirdThreeUpleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ThreeUple<string, double, string> thirdThreeUple = new ThreeUple<string, double, string>(thirdThreeUpleInfo[0],double.Parse(thirdThreeUpleInfo[1]),thirdThreeUpleInfo[2]);

            Console.WriteLine($"{firstThreeUple.Type1} -> {firstThreeUple.Type2} -> {firstThreeUple.Type3}");
            Console.WriteLine($"{secondThreeUple.Type1} -> {secondThreeUple.Type2} -> {secondThreeUple.Type3}");
            Console.WriteLine($"{thirdThreeUple.Type1} -> {thirdThreeUple.Type2} -> {thirdThreeUple.Type3}");
        }
        
    }
}
