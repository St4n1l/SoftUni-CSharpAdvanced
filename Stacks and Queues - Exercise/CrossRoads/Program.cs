using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (input != "END")
            {
                int durationOfGreenLightCopy = durationOfGreenLight;
                int freePass = freeWindow;
                if (input == "green")
                {
                    while (cars.Count != 0 && durationOfGreenLightCopy > 0)
                    {
                        string currentCar = cars.Dequeue();
                        durationOfGreenLightCopy -= currentCar.Count();
                        if (durationOfGreenLightCopy >= 0)
                        {
                            counter++;
                        }
                        else
                        {
                            freePass += durationOfGreenLightCopy;
                            if (freePass < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                                  $"{currentCar} was hit at" +
                                                  $" {currentCar[currentCar.Length + freePass]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");

        }
    }
}
