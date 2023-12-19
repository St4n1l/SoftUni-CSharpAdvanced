using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            string snake = Console.ReadLine();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int currentIndexOfWord = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = snake[currentIndexOfWord];
                        currentIndexOfWord++;
                        if (currentIndexOfWord == snake.Length)
                        {
                            currentIndexOfWord = 0;
                        }
                    }
                }
                else
                {
                    for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
                    {
                        matrix[rows, cols] = snake[currentIndexOfWord];
                        currentIndexOfWord++;
                        if (currentIndexOfWord == snake.Length)
                        {
                            currentIndexOfWord = 0;
                        }
                    }
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }

                Console.WriteLine();
            }
        }
    }
}