using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = currentRow[cols];
                }
            }

            int currentSum = 0, maxSum = 0;
            int maxRow = 0, maxCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                    currentSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                                 matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                                 matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = rows;
                        maxCol = cols;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int rows = maxRow; rows < maxRow + 3; rows++)
            {
                for (int cols = maxCol; cols < maxCol + 3; cols++)
                {
                    Console.Write($"{matrix[rows, cols]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
