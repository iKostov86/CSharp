using System;
using System.Text;

class AnyBaseSToAnyBaseD
{
    static void Main()
    {
        Console.WriteLine("Enter a numeral system base 's': ");
        int sBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a numeral system base 'd': ");
        int dBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number in 's' based system: ");
        string numberInSBase = Console.ReadLine();
        string numberInDBase = string.Empty;

        if (sBase == 10)
        {
            numberInDBase = ConvertFromDecimalToDbasedSystem(long.Parse(numberInSBase), dBase);
        }
        else
        {
            long decimalNumber = ConvertFromSBasedSystemToDecimal(numberInSBase, sBase);
            if (dBase == 10)
            {
                string reversedList = decimalNumber.ToString();
                for (int i = reversedList.Length - 1; i > -1; i--)
                {
                    numberInDBase += reversedList[i];
                }
            }
            else
            {
                numberInDBase = ConvertFromDecimalToDbasedSystem(decimalNumber, dBase);
            }
        }

        PrintNumberInDBasedSystem(numberInDBase);
    }

    static long ConvertFromSBasedSystemToDecimal(string numberInSBase, int sBase)
    {
        long decimalNumber = new long();
        long valueAtIndex = new long();
        long pow = 0;

        for (int i = numberInSBase.Length - 1; i > -1; i--)
        {
            valueAtIndex = numberInSBase[i] - 48;
            if (valueAtIndex > 9)
            {
                valueAtIndex -= 7;
            }
            decimalNumber += valueAtIndex * (long)(Math.Pow(sBase, pow));
            pow++;
        }

        return decimalNumber;
    }

    static string ConvertFromDecimalToDbasedSystem(long decimalNumber, int dBase)
    {
        StringBuilder reversedList = new StringBuilder();

        while (decimalNumber != 0)
        {
            if ((decimalNumber % dBase) > 9)
            {
                reversedList.Append((char)((decimalNumber % dBase) + 55));
            }
            else
            {
                reversedList.Append(decimalNumber % dBase);
            }
            decimalNumber /= dBase;
        }

        return reversedList.ToString();
    }

    static void PrintNumberInDBasedSystem(string numberInDBase)
    {
        Console.WriteLine();
        for (int i = numberInDBase.Length - 1; i > -1; i--)
        {
            Console.Write(numberInDBase[i]);
        }
        Console.WriteLine();
    }
}
