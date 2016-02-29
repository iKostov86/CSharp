using System;
using System.Linq;

public class LongestSequenceOfEqualStrings
{

    internal static void Main()
    {
        //string[,] matrix = new string[,]
        //{
        //    {"s", "qq", "s"},
        //    {"pp", "pp", "s"},
        //    {"pp", "qq", "s"},
        //};
        string[,] matrix = new string[,]
        {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
        };

        string bestSequence = String.Empty;
        int bestCount = 0;
        int rowLen = matrix.GetLength(0);
        int colLen = matrix.GetLength(1);
        int diagonal = (rowLen < colLen) ? rowLen : colLen;

        /*** horizontal check ***/
        for (int row = 0; row < rowLen; row++)
        {
            string sequence = matrix[row, 0];
            int count = 1;

            for (int col = 1; col < colLen; col++)
            {
                bool isLastCol = (col == colLen - 1);

                if (sequence == matrix[row, col])
                {
                    count++;

                    if (isLastCol && count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastCol)
                    {
                        sequence = matrix[row, col];
                        count = 1;
                    }
                }
            }
        }

        /*** vertical check ***/
        for (int col = 0; col < colLen; col++)
        {
            string sequence = matrix[0, col];
            int count = 1;

            for (int row = 1; row < rowLen; row++)
            {
                bool isLastRow = (row == rowLen - 1);

                if (sequence == matrix[row, col])
                {
                    count++;

                    if (isLastRow && count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastRow)
                    {
                        sequence = matrix[row, col];
                        count = 1;
                    }
                }
            }
        }

        /*** diagonal check top to bottom ***/
        /* left half */
        for (int row = 0; row < rowLen; row++)
        {
            string sequence = matrix[row, 0];
            int count = 1;

            for (int checkRow = row + 1, checkCol = 1; checkRow < diagonal && checkCol < diagonal; checkRow++, checkCol++)
            {
                bool isLastIndex = (checkRow == rowLen - 1 || checkCol == colLen - 1);

                if (sequence == matrix[checkRow, checkCol])
                {
                    count++;

                    if (isLastIndex && count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastIndex)
                    {
                        sequence = matrix[checkRow, checkCol];
                        count = 1;
                    }
                }
            }
        }

        /* right half */
        for (int col = 1; col < colLen; col++)
        {
            string sequence = matrix[0, col];
            int count = 1;

            for (int checkRow = 1, checkCol = col + 1; checkRow < diagonal && checkCol < diagonal; checkRow++, checkCol++)
            {
                bool isLastIndex = (checkRow == rowLen - 1 || checkCol == colLen - 1);

                if (sequence == matrix[checkRow, checkCol])
                {
                    count++;

                    if (isLastIndex && count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastIndex)
                    {
                        sequence = matrix[checkRow, checkCol];
                        count = 1;
                    }
                }
            }
        }

        /*** diagonal check bottom to top ***/
        /* left half */
        for (int row = rowLen - 1; row >= 0; row--)
        {
            string sequence = matrix[row, 0];
            int count = 1;

            for (int checkRow = row - 1, checkCol = 1; checkRow >= 0 && checkCol < diagonal; checkRow--, checkCol++)
            {
                bool isLastIndex = (checkRow == 0 || checkCol == colLen - 1);

                if (sequence == matrix[checkRow, checkCol] && !isLastIndex)
                {
                    count++;
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastIndex)
                    {
                        sequence = matrix[checkRow, checkCol];
                        count = 1;
                    }
                }
            }
        }

        /* right half */
        for (int col = 1; col < colLen; col++)
        {
            string sequence = matrix[rowLen - 1, col];
            int count = 1;

            for (int checkRow = rowLen - 2, checkCol = col + 1; checkRow >= 0 && checkCol < diagonal; checkRow--, checkCol++)
            {
                bool isLastIndex = (checkRow == 0 || checkCol == colLen - 1);

                if (sequence == matrix[checkRow, checkCol])
                {
                    count++;

                    if (isLastIndex && count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestSequence = sequence;
                        bestCount = count;
                    }

                    if (!isLastIndex)
                    {
                        sequence = matrix[checkRow, checkCol];
                        count = 1;
                    }
                }
            }
        }

        PrintLongestSequence(bestSequence, bestCount);
    }

    public static void PrintLongestSequence(string sequence, int count)
    {
        Console.Write("Longest sequence is: ");
        Console.WriteLine(string.Join(" ", Enumerable.Repeat(sequence, count)));
        //Console.WriteLine(string.Concat(Enumerable.Repeat(sequence + " ", count)));
    }
}