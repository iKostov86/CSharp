using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        int decNumber = int.Parse(Console.ReadLine());
        ConvertDecimalToHexadecimal(decNumber);
    }

    static void ConvertDecimalToHexadecimal(int number)
    {
        List<int> array = new List<int>();
        while (number != 0)
        {
            array.Add(number % 16);
            number /= 16;
        }
        array.Reverse();
        PrintConvertedNumber(array);
    }

    static void PrintConvertedNumber(List<int> array)
    {
        Console.Write("\r\n0x");
        foreach (var item in array)
        {
            switch (item)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(item);
                    break;
            }
        }
        Console.WriteLine("\r\n");
    }
}

