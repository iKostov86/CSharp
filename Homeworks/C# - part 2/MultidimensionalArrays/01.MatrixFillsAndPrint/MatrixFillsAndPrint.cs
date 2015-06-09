using System;

class MatrixFillsAndPrint
{
    static void Main()
    {
        int[,] matrix = new int[, ]
        {
            { 1, 5 ,9 , 13 },
            { 2, 6, 10, 14 },
            { 3, 7, 11, 15 },
            { 4, 8, 12, 16 },
        };

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

        //Console.WriteLine();

        Console.WriteLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();

    }
}
