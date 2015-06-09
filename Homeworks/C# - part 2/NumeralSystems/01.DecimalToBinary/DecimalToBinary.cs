using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        ConvertDecimalToBinary(decimalNumber);
    }

    static void ConvertDecimalToBinary<T>(T number)
    {
        StringBuilder list = new StringBuilder();
        while (number != (dynamic)0)
        {
            list.Append(number & (dynamic)1);
            number = number >> (dynamic)1;
        }

        PrintConvertNumber(list);

        //List<dynamic> array = new List<dynamic>();
        //while (number > (dynamic)0)
        //{
        //    array.Add(number & (dynamic)1);
        //    number = number >> (dynamic)1;
        //}

        //array.Reverse();
        //PrintConvertedNumber(array);
    }

    static void PrintConvertedNumber<T>(List<T> array)
    {
        Console.WriteLine();
        Console.Write("0b ");
        int count = 4;
        foreach (var item in array)
        {
            if (count == 0)
            {
                Console.Write(" ");
                count = 4;
            }
            else
            {
                count--;
            }
            Console.Write(item);
        }
        Console.WriteLine("\r\n\r\n");
    }

    static void PrintConvertNumber(StringBuilder list)
    {
        int count = list.Length % 4;
        Console.WriteLine();
        Console.Write("0b ");
        if (count != 0)
        {
            for (int i = 4 - count; i > 0; i--)
            {
                Console.Write("0");
            }
        }

        if (list.Length != 0)
        {
            for (int i = list.Length - 1; i > -1; i--)
            {
                if (count == 0)
                {
                    Console.Write(" ");
                    count = 3;
                }
                else
                {
                    count--;
                }
                Console.Write(list[i]);
            }
        }
        else
        {
            Console.WriteLine("0000");
        }

        Console.WriteLine("\r\n\r\n");

    }
}
