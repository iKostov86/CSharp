using System;
using System.Collections.Generic;

class ConvertFromHexadecimalToDecimal
{
    static void Main()
    {
        uint numDecimal = 0;
        uint multiplier = 0;
        string numHexa;
        Console.WriteLine("Please enter a hexadecimal number: ");
        numHexa = Console.ReadLine();
        Console.WriteLine();

        for (int i = numHexa.Length - 1; i >= 0; i--)
        {
            switch (numHexa[i])
            {
                case '0':
                    multiplier = 0;
                    break;
                case '1':
                    multiplier = 1;
                    break;
                case '2':
                    multiplier = 2;
                    break;
                case '3':
                    multiplier = 3;
                    break;
                case '4':
                    multiplier = 4;
                    break;
                case '5':
                    multiplier = 5;
                    break;
                case '6':
                    multiplier = 6;
                    break;
                case '7':
                    multiplier = 7;
                    break;
                case '8':
                    multiplier = 8;
                    break;
                case '9':
                    multiplier = 9;
                    break;
                case 'A':
                    multiplier = 10;
                    break;
                case 'B':
                    multiplier = 11;
                    break;
                case 'C':
                    multiplier = 12;
                    break;
                case 'D':
                    multiplier = 13;
                    break;
                case 'E':
                    multiplier = 14;
                    break;
                case 'F':
                    multiplier = 15;
                    break;
                default:
                    break;
            }
            numDecimal += multiplier * (uint)Math.Pow(16, numHexa.Length - 1 - i);
        }

        Console.WriteLine(numDecimal);
    }
}
