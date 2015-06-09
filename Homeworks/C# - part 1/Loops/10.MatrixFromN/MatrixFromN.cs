using System;

class MatrixFromN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();

            for (int j = i; j <= (i + n - 1); j++)
            {
                Console.Write(j);
                Console.Write(" ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();

    }
}
