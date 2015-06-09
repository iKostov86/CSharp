using System;
using System.Collections.Generic;

class ConvertFromDecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number: ");
        uint[] numBinary = new uint[8];
        uint numDecimal = 0;
        bool check = true;

        for (int i = 7; i > -1; i--)
        {
            //numBinary[i] = uint.Parse(Console.ReadLine());
            check = uint.TryParse(Console.ReadLine(), out numBinary[i]);

            if ((!check) || (numBinary[i] != 0 && numBinary[i] != 1))
            {
                Console.WriteLine("Invalid number!");
                return;
            }
        }

        Console.WriteLine();

        for (int i = 0; i < numBinary.Length; i++)
        {
            if (numBinary[i] == 1u)
            {
                numDecimal += (uint)Math.Pow(2, i);

            }
        }

        Console.WriteLine(numDecimal);

    }
}
