using System;

class DepthFirstSearch
{
    public static int[,] matrix = new int[,]
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1},
            };

    public static int result = 0;
    public static int comparer = 0;


    static void Main()
    {
        int theBestNumber = 0;
        int theBestResult = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                comparer = matrix[i, j];
                DFSMethod(i, j);
                if (result > theBestResult)
                {
                    theBestNumber = comparer;
                    theBestResult = result;
                }
                result = 0;
            }
        }
        Console.WriteLine("The number is {0}, the size of largest area is {1}", theBestNumber, theBestResult);
    }

    static void DFSMethod(int row, int col)
    {
        if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
        {
            return;
        }

        if (matrix[row, col] != comparer || matrix[row, col] == -1)
        {
            return;
        }

        result++;
        matrix[row, col] = -1;

        DFSMethod(row, col - 1);      //left
        DFSMethod(row - 1, col);      //up
        DFSMethod(row, col + 1);      //right
        DFSMethod(row + 1, col);      //down
    }
}
