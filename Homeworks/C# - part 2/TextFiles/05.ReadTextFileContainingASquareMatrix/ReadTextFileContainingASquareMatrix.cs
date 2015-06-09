using System;
using System.Collections.Generic;
using System.IO;

public class ReadTextFileContainingASquareMatrix
{
    public const int MatrixSize = 4;
    public const int AreaSize = 2;

    internal static void Main()
    {
        string fileName = "SquareMatrix.txt";

        if (!File.Exists(fileName))
        {
            string createMatrix = MatrixSize + Environment.NewLine +
                                  "2 3 3 4" + Environment.NewLine +
                                  "0 2 3 4" + Environment.NewLine +
                                  "3 7 1 2" + Environment.NewLine +
                                  "4 3 3 2";
            File.WriteAllText(fileName, createMatrix);
        }

        ////Read file and store int matrix array

        TextReader myreader = new StreamReader(fileName);

        int matrixLength = int.Parse(myreader.ReadLine());
        int[,] matrix = new int[matrixLength, matrixLength];

        int total = 0;
        int temp = 0;

        using (myreader)
        {
            string lineContain = string.Empty;

            for (int row = 0; row < matrixLength; row++)
            {
                lineContain = myreader.ReadLine().Replace(" ", string.Empty);

                for (int col = 0; col < matrixLength; col++)
                {
                    matrix[row, col] = int.Parse(lineContain[col].ToString());
                }
            }
        }

        ////Get a maximal sum

        for (int row = 0; row < matrixLength - (AreaSize - 1); row++)
        {
            for (int col = 0; col < matrixLength - (AreaSize - 1); col++)
            {
                temp = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (temp > total)
                {
                    total = temp;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", total);
        Console.WriteLine();
    }
}
