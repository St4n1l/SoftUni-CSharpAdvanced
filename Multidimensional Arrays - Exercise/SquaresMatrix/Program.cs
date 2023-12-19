using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] chars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = chars[col];
                }
            }

            int count = 0;

            if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
            {
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                    {
                        if (matrix[rows, cols] == matrix[rows, cols + 1] && matrix[rows, cols] == matrix[rows + 1, cols + 1] && matrix[rows + 1, cols] == matrix[rows + 1, cols + 1])
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}