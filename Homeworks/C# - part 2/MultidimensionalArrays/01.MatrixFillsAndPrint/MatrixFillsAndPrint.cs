using System;

public class MatrixFillsAndPrint
{
    internal static void Main()
    {
        //int[,] matrix = new int[,]
        //{
        //    { 1, 5 ,9 , 13 },
        //    { 2, 6, 10, 14 },
        //    { 3, 7, 11, 15 },
        //    { 4, 8, 12, 16 },
        //};

        int[,] matrix = GetMatrix();

        PrintMatrix(matrix);
    }

    public static int[,] GetMatrix()
    {
        Random gen = new Random();
        int firstDimension = int.Parse(Console.ReadLine());
        int secondDimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[firstDimension, secondDimension];

        for (int row = 0, rowLen = matrix.GetLength(0); row < rowLen; row++)
        {
            for (int col = 0, colLen = matrix.GetLength(1); col < colLen; col++)
            {
                //matrix[row, col] = int.Parse(Console.ReadLine());
                matrix[row, col] = gen.Next(1, 99);
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0, rowsLen = matrix.GetLength(0); row < rowsLen; row++)
        {
            for (int col = 0, colLen = matrix.GetLength(1); col < colLen; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}
