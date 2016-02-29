using System;

public class MaxPlatform
{
    private const int PLATFORM_SIZE = 3;

    internal static void Main()
    {
        /* we find maximal square 3x3 */
        int[,] matrix = new int[,]
        {
            { 1, 5, 99, 13, 17 },
            { 2, 6, 10, 14, 18 },
            { 3, 7, 11, 15, 19 },
            { 4, 8, 12, 16, 20 },
        };

        if (matrix.GetLength(0) < PLATFORM_SIZE || matrix.GetLength(1) < PLATFORM_SIZE)
        {
            Console.WriteLine("The matrix is smaller than the platform.");
            return;
        }

        int sum = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row <= matrix.GetLength(0) - PLATFORM_SIZE; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - PLATFORM_SIZE; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        PrintBestPlatform(matrix, bestRow, bestCol);
        Console.WriteLine("The best sum is: {0}", bestSum);
    }

    public static void PrintBestPlatform(int[,] matrix, int bestRow, int bestCol)
    {
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}