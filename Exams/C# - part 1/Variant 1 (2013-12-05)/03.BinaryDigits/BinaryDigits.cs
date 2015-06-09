using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryDigits
{
    static void Main()
    {
        StringBuilder myBuilder = new StringBuilder();
        ulong number = ulong.Parse(Console.ReadLine());

        GetBits(ref number, ref myBuilder);

        for (int i = 1; i <= 4; i++)
        {
            PrintBits(ref myBuilder, i);
            Console.WriteLine();
        }
    }

    static void GetBits(ref ulong number, ref StringBuilder myBuilder)
    {
        int count = 0;

        while (number != 0 && count != 16)
        {
            myBuilder.Append(number % 2);
            number /= 2;
            count++;
        }

        for (int i = 0; myBuilder.Length < 16; i++)
        {
            myBuilder.Append("0");
        }
    }
    static void PrintBits(ref StringBuilder myBuilder, int row)
    {
        for (int i = myBuilder.Length - 1; i > -1; i--)
        {
            PrintRow(myBuilder[i], row);

            if (i != 0)
            {
                Console.Write(" ");
            }
        }
    }

    static void PrintRow(char bit, int row)
    {
        if (bit == '1')
        {
            if (row == 1 || row == 3)
            {
                Console.Write(".#.");
            }
            else if (row == 2)
            {
                Console.Write("##.");
            }
            else
            {
                Console.Write("###");
            }
        }
        else
        {
            if (row == 1 || row == 4)
            {
                Console.Write("###");
            }
            else
            {
                Console.Write("#.#");
            }
        }
    }
}
