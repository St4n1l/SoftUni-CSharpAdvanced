using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine());
            Queue<PetrolPump> petrolPumps = new Queue<PetrolPump>();
            for (int i = 0; i < numOfPumps; i++)
            {
                int[] currentPumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                petrolPumps.Enqueue(new PetrolPump(currentPumpInfo[0], currentPumpInfo[1]));
            }

            int count = 0;
            while (true)
            {
                int currentLiters = 0;
                bool valid = true;
                for (int i = 0; i < petrolPumps.Count; i++)
                {
                    PetrolPump currentPump = petrolPumps.Dequeue();
                    currentLiters += currentPump.Liters;
                    currentLiters -= currentPump.Distance;
                    petrolPumps.Enqueue(currentPump);

                    if (currentLiters < 0)
                    {
                        valid = false;
                    }

                }

                if (valid)
                {
                    break;
                }

                count++;
                petrolPumps.Enqueue(petrolPumps.Dequeue());
            }

            Console.WriteLine(count);
        }
    }

    class PetrolPump
    {
        public PetrolPump(int liters, int distance)
        {
            Liters = liters;
            Distance = distance;
        }
        public int Liters { get; set; }
        public int Distance { get; set; }

    }
}