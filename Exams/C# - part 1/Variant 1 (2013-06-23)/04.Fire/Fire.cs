using System;

class Fire
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < width / 2; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((j + i) == (width / 2) - 1 || (j - i) == width / 2)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int i = (width / 2) - 1; i >=  width / 4; i--)
        {
            for (int j = width - 1; j >= 0; j--)
            {
                if ((j + i) == (width / 2) - 1 || (j - i) == width / 2)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', width));

        for (int i = 0; i < width / 2; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j < i || j > width - i - 1)
                {
                    Console.Write(".");
                }
                else if (j < (width / 2))
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write("/");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
