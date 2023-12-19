using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            int leftSum = 0, rightSum = 0;
            for (int i = 0, j = size - 1; i < size; i++, j--)
            {
                leftSum += matrix[i, i];
                rightSum += matrix[i, j];
            }

            Console.WriteLine(Math.Abs(leftSum - rightSum));

        }
    }
}
