using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];

            for (int rows = 0; rows < n; rows++)
            {
                double[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();
                jaggedArray[rows] = new double[currentRow.Length];
                for (int cols = 0; cols < currentRow.Length; cols++)
                {
                    jaggedArray[rows][cols] = currentRow[cols];
                }
            }

            for (int rows = 0; rows < jaggedArray.GetLength(0) - 1; rows++)
            {
                if (jaggedArray[rows].Length == jaggedArray[rows + 1].Length)
                {
                    for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                    {
                        jaggedArray[rows][cols] *= 2;
                        jaggedArray[rows + 1][cols] *= 2;
                    }
                }
                else
                {
                    for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                    {
                        jaggedArray[rows][cols] /= 2;
                    }

                    for (int cols = 0; cols < jaggedArray[rows + 1].Length; cols++)
                    {
                        jaggedArray[rows + 1][cols] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    if (IsValid(jaggedArray, command))
                    {
                        jaggedArray[int.Parse(command[1])][int.Parse(command[2])] += double.Parse(command[3]);
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (IsValid(jaggedArray, command))
                    {
                        jaggedArray[int.Parse(command[1])][int.Parse(command[2])] -= double.Parse(command[3]);
                    }
                }

            }

            for (int rows = 0; rows < jaggedArray.GetLength(0); rows++)
            {
                for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                {
                    Console.Write($"{jaggedArray[rows][cols]} ");
                }

                Console.WriteLine();
            }

        }

        static bool IsValid(double[][] jaggedArray, string[] command)
        {
            if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < jaggedArray.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < jaggedArray[int.Parse(command[1])].Length)
            {
                return true;
            }
            return false;
        }
    }
}
