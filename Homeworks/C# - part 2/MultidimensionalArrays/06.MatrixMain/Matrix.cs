using System;

public class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        if (first.Rows == second.Rows && first.Columns == second.Columns)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);

            for (int row = 0, rowLen = first.Rows; row < rowLen; row++)
            {
                for (int col = 0, colLen = second.Columns; col < colLen; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;
        }

        return new Matrix(0, 0);
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = string.Empty;

        for (int row = 0, rowLen = this.Rows; row < rowLen; row++)
        {
            for (int col = 0, colLen = this.Columns; col < colLen; col++)
            {
                result += matrix[row, col] + " ";
            }

            result += Environment.NewLine;
        }

        return result;
    }
}
