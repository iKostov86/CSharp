using System;

class MaxPlatform
{
    static void Main()
    {
        //int nSize = int.Parse(Console.ReadLine());
        //int mSize = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[nSize, mSize];

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        /* we find maximal square 3x3 */

        int[,] matrix = new int[,]
        {
            { 1, 5 ,9 , 13, 17 },
            { 2, 6, 10, 14, 18 },
            { 3, 7, 11, 15, 19 },
            { 4, 8, 12, 16, 20 },
        };
        int total = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
            {
                total = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (total > bestSum)
                {
                    bestSum = total;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine();

        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Total: {0}", bestSum);
        Console.WriteLine();
    }
}