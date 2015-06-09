using System;
using System.Collections.Generic;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        string[,] matrix = new string[,]
            {
                {"ha", "fifi", "ho", "hi"},
                {"fo", "ha", "hi", "xx"},
                {"xxx", "ho", "ha", "xx"},
            };
        //string[,] matrix = new string[,]
        //    {
        //        {"s", "qq", "s"},
        //        {"pp", "pp", "s"},
        //        {"pp", "qq", "s"},
        //    };

        List<string> bestSequence = new List<string>();
        List<string> currentSequence = new List<string>();
        //int diagonalSize = (matrix.GetLength(0) < matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);

        /*** horizontal chek ***/
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[row, 0]);
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[row, col]);
                }
                if ((matrix[row, col] != currentSequence[currentSequence.Count - 1]) ||
                    (col == matrix.GetLength(1) - 1))
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[row, col]);
                }
            }
        }

        /*** vertical chek ***/
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[0, col]);
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[row, col]);
                }
                if ((matrix[row, col] != currentSequence[currentSequence.Count - 1]) ||
                    (row == matrix.GetLength(0) - 1))
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[row, col]);
                }
            }
        }

        /*** diagonal check top to bottom ***/
        /* left half */
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[row, 0]);
            for (int checkRow = row + 1, checkCol = 1; checkRow < matrix.GetLength(0) && checkCol < matrix.GetLength(1); checkRow++, checkCol++)
            {
                if (matrix[checkRow, checkCol] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
                if (matrix[checkRow, checkCol] != currentSequence[currentSequence.Count - 1] || checkCol == matrix.GetLength(1) - 1 || checkRow == matrix.GetLength(0) - 1)
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
            }
        }
        /* right half */
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[0, col]);
            for (int checkRow = 1, checkCol = col + 1; checkRow < matrix.GetLength(0) && checkCol < matrix.GetLength(1); checkRow++, checkCol++)
            {
                if (matrix[checkRow, checkCol] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
                if (matrix[checkRow, checkCol] != currentSequence[currentSequence.Count - 1] || checkCol == matrix.GetLength(1) - 1 || checkRow == matrix.GetLength(0) - 1)
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
            }
        }

        /*** diagonal chek bottom to top ***/
        /* left half */
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[row, 0]);
            for (int checkRow = row - 1, checkCol = 1; 
                 checkRow >= 0 && checkCol < matrix.GetLength(1); checkRow--, checkCol++)
            {
                if (matrix[checkRow, checkCol] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
                if (matrix[checkRow, checkCol] != currentSequence[currentSequence.Count - 1] || checkCol == matrix.GetLength(1) - 1 || checkRow == 0)
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
            }
        }
        /* right half */
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            currentSequence = new List<string>();
            currentSequence.Add(matrix[matrix.GetLength(0) - 1, col]);
            for (int checkRow = matrix.GetLength(0) - 2, checkCol = col + 1;
                 checkRow >= 0 && checkCol < matrix.GetLength(1); checkRow--, checkCol++)
            {
                if (matrix[checkRow, checkCol] == currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
                if (matrix[checkRow, checkCol] != currentSequence[currentSequence.Count - 1] || checkCol == matrix.GetLength(1) - 1 || checkRow == 0)
                {
                    if (bestSequence.Count < currentSequence.Count)
                    {
                        bestSequence = currentSequence;
                    }
                    currentSequence = new List<string>();
                    currentSequence.Add(matrix[checkRow, checkCol]);
                }
            }
        }

        Console.Write("Longest sequence: ");
        foreach (var item in bestSequence)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}