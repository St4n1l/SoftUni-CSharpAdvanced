using System;
using System.Runtime.InteropServices;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[size, size];

            for (int rows = 0; rows < size; rows++)
            {
                string currentRow = Console.ReadLine();

                for (int cols = 0; cols < size; cols++)
                {
                    chessBoard[rows, cols] = currentRow[cols];
                }
            }

            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }

            int knightNeeded = 0;
            int maxCount = 0;
            int mostRow = 0;
            int mostCol = 0;

            while (true)
            {
                for (int rows = 0; rows < size; rows++)
                {
                    for (int cols = 0; cols < size; cols++)
                    {
                        if (chessBoard[rows, cols] == 'K')
                        {
                            int currentCount = IsAttacking(rows, cols, chessBoard, size);

                            if (currentCount > maxCount)
                            {
                                maxCount = currentCount;
                                mostRow = rows;
                                mostCol = cols;
                            }

                        }
                    }
                }

                if (maxCount == 0)
                {
                    break;
                }
                else
                {
                    maxCount = 0;
                    chessBoard[mostRow, mostCol] = '0';
                    knightNeeded++;
                }
            }

            Console.WriteLine(knightNeeded);
        }

        static int IsAttacking(int rows, int cols, char[,] chessBoard, int size)
        {
            // up = -    down = +  left = -   right = +
            int knightsAttacked = 0;
            //2left-1up
            if (CellIsValid(rows - 1, cols - 2, size))
            {
                if (chessBoard[rows - 1, cols - 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2left-1down

            if (CellIsValid(rows + 1, cols - 2, size))
            {
                if (chessBoard[rows + 1, cols - 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2up - 1left
            if (CellIsValid(rows - 2, cols - 1, size))
            {
                if (chessBoard[rows - 2, cols - 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2up - 1 right
            if (CellIsValid(rows - 2, cols + 1, size))
            {
                if (chessBoard[rows - 2, cols + 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2 right - 1up
            if (CellIsValid(rows - 1, cols + 2, size))
            {
                if (chessBoard[rows - 1, cols + 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2 right - 1 down
            if (CellIsValid(rows + 1, cols + 2, size))
            {
                if (chessBoard[rows + 1, cols + 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            //2down - 1left
            if (CellIsValid(rows + 2, cols - 1, size))
            {
                if (chessBoard[rows + 2, cols - 1] == 'K')
                {
                    knightsAttacked++;
                }
            }


            //2down - 1 right
            if (CellIsValid(rows + 2, cols + 1, size))
            {
                if (chessBoard[rows + 2, cols + 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            return knightsAttacked;
        }

        static bool CellIsValid(int rows, int cols, int size)
        {
            if (rows >= 0 && rows < size && cols >= 0 && cols < size)
            {
                return true;
            }

            return false;
        }
    }
}
