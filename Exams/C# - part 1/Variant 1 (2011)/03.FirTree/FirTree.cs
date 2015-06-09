using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int pointLine = 2 * n - 3;
        int middle = pointLine / 2;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < pointLine; j++)
            {
                if (j < (middle - i) || j > (middle + i))
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        for (int i = 0; i < pointLine; i++)
        {
            if (i < middle || i > middle)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("*");
            }
        }
    }
}
