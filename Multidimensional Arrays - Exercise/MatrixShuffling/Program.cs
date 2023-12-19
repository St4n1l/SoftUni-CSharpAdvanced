using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = currentRow[cols];
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    int oldRow = int.Parse(command[1]);
                    int oldCol = int.Parse(command[2]);
                    int newRow = int.Parse(command[3]);
                    int newCol = int.Parse(command[4]);

                    if (oldRow >= 0 && oldRow < matrix.GetLength(0) - 1 && oldCol >= 0 && oldCol <= matrix.GetLength(1) - 1 && newRow >= 0 && newRow <= matrix.GetLength(0) - 1 && newCol >= 0 && newCol <= matrix.GetLength(1) - 1)
                    {
                        string swap = matrix[oldRow, oldCol];
                        matrix[oldRow, oldCol] = matrix[newRow, newCol];
                        matrix[newRow, newCol] = swap;

                        for (int rows = 0; rows < matrix.GetLength(0); rows++)
                        {
                            for (int cols = 0; cols < matrix.GetLength(1); cols++)
                            {
                                Console.Write($"{matrix[rows, cols]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

        }
    }
}
