using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sudoku
{
    static void Main()
    {
        int[,] puzzle = new int[9, 9]
        {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 },
        };

        int[,] puzzleOutput = new int[9, 9]
        {
            { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
            { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
            { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
            { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
            { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            { 3, 4, 5, 2, 8, 6, 1, 7, 9 },
        };

        PrintPuzzle(puzzle);
        PrintPuzzle(puzzleOutput);

        for (int row = 0; row < puzzle.GetLength(0); row++)
        {
            for (int col = 0; col < puzzle.GetLength(1); col++)
            {
                if (puzzle[row, col] == 0)
                {
                    for (int digit = 1; digit <= 9; digit++)
                    {
                        bool positionOk = true;

                        for (int vertical = 0; vertical < 9; vertical++)
                        {
                            if (digit == puzzle[vertical, col])
                            {
                                positionOk = false;
                                break;
                            }
                        }
                        if (!positionOk)
                        {
                            continue;
                        }
                        for (int horizontal = 0; horizontal < 9; horizontal++)
                        {
                            if (digit == puzzle[row, horizontal])
                            {
                                positionOk = false;
                                break;
                            }
                        }
                        if (!positionOk)
                        {
                            continue;
                        }
                        for (int subRow = (row - (row % 3)); subRow < (row - (row % 3) + 3); subRow++)
                        {
                            for (int subCol = (col - (col % 3)); subCol < (col - (col % 3) + 3); subCol++)
                            {
                                if (digit == puzzle[subRow, subCol])
                                {
                                    positionOk = false;
                                    break;
                                }
                            }
                        }

                        if (positionOk)
                        {
                            puzzle[row, col] = digit;
                            break;
                        }
                    }
                }
            }
        }

        PrintPuzzle(puzzle);
    }

    public static void PrintPuzzle(int[,] puzzle)
    {
        for (int i = 0; i < puzzle.GetLength(0); i++)
        {
            for (int j = 0; j < puzzle.GetLength(1); j++)
            {
                if (puzzle[i, j] == 0)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write(puzzle[i, j] + " ");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
