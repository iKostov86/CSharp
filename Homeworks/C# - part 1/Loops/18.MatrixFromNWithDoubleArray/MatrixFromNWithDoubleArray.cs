using System;

class MatrixFromNWithDoubleArray
{
    static void Main()
    {
        Console.WriteLine("Enter a number (n): ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int num = 1;
        Console.WriteLine();

        for (int depth = 0; depth < n / 2 + n % 2; depth++)
        {
            for (int col = depth; col < n - depth; col++)
            {
                array[depth, col] = num;
                num++;
            }
            for (int row = 1 + depth; row < n - depth; row++)
            {
                array[row, n - 1 - depth] = num;
                num++;
            }
            for (int col = n - 2 - depth; col >= depth; col--)
            {
                array[n - 1 - depth, col] = num;
                num++;
            }
            for (int row = n - 2 - depth; row > depth; row--)
            {
                array[row, depth] = num;
                num++;
            }
        }

        PrintArray(array);
        Console.WriteLine();

    }

    private static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0,4}", array[row, col]);
            }
            Console.WriteLine("\n\r");
        }
    }
}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace SpiralRectangleEx14
//{
//    class SpiralRectangle
//    {
//        static void Main()
//        {
//            string stringNumber = Console.ReadLine();
//            int matrixSize = int.Parse(stringNumber);
//            int[,] matrix = new int[matrixSize, matrixSize];
//            int num = 1;

//            for (int depth = 0; depth < matrixSize / 2 + matrixSize % 2; depth++)
//            {
//                for (int col = depth; col < matrixSize - depth; col++)
//                {
//                    matrix[depth, col] = num;
//                    num++;
//                }

//                for (int row = 1 + depth; row < matrixSize - depth; row++)
//                {
//                    matrix[row, matrixSize - 1 - depth] = num;
//                    num++;
//                }

//                for (int col = matrixSize - 2 - depth; col >= depth; col--)
//                {
//                    matrix[matrixSize - 1 - depth, col] = num;
//                    num++;
//                }

//                for (int row = matrixSize - 2 - depth; row > depth; row--)
//                {
//                    matrix[row, depth] = num;
//                    num++;
//                }
//            }

//            PrintMatrix(matrix);
//        }

//        private static void PrintMatrix(int[,] matrix)
//        {
//            for (int row = 0; row < matrix.GetLength(0); row++)
//            {
//                for (int col = 0; col < matrix.GetLength(1); col++)
//                {
//                    Console.Write("{0,4}", matrix[row, col]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

