using System;
using System.Collections.Generic;
using System.Text;

class FloatToBinary
{
    static void Main()
    {
        float number = -73.2031f;
        Console.WriteLine("The internal binary representation of {0} in IEEE 754 format : ", number);
        Console.WriteLine("| {0} | {1,8} | {2,-23} |",
        "sign", "exponent", "mantissa");
        Console.Write("| {0,4} | {1} | {2} |",
        GetSign(number), GetExponent(number), GetMantissa(number));
    }

    private static string GetSign(float number)
    {
        if (number >= 0)
        {
            return "0";
        }
        else
        {
            return "1";
        }
    }

    private static string GetExponent(float number)
    {
        StringBuilder exponent = new StringBuilder();
        if (number < 0)
        {
            number *= -1;
        }
        int exp = (int)(Math.Floor(Math.Log(number, 2)));
        exponent.Append(ConvertDecimalToBinary(exp + 127));
        return exponent.ToString();
    }

    private static string GetMantissa(float number)
    {
        if (number < 0)
        {
            number *= -1;
        }
        string integer = ConvertDecimalToBinary((int)number);
        string fraction = GetDecimalToBinaryFraction(number);
        StringBuilder mantissa = new StringBuilder();
        if (integer.Length != 0)
        {
            mantissa.Append(integer.Substring(1) + fraction);
        }
        else
        {
            mantissa.Append(fraction.Substring(fraction.IndexOf('1') + 1));
        }
        return mantissa.ToString().PadRight(23, '0');
    }

    private static string GetDecimalToBinaryFraction(float number)
    {
        StringBuilder fraction = new StringBuilder();
        float temp = number - (int)number;
        do
        {
            temp *= 2;
            fraction.Append((int)temp);
            temp -= (int)temp;
        } while (temp != 0);
        return fraction.ToString();
    }

    private static string ConvertDecimalToBinary(int decimalNumber)
    {
        const int baseFormat = 2;
        List<int> binaryNumber = new List<int>();
        while (decimalNumber != 0)
        {
            binaryNumber.Add((decimalNumber % baseFormat));
            decimalNumber /= baseFormat;
        }
        StringBuilder result = new StringBuilder();
        for (int index = binaryNumber.Count - 1; index >= 0; index--)
        {
            result.Append(binaryNumber[index]);
        }
        return Convert.ToString(result);
    }
}


//using System;
//using System.Linq;
//class PrintBinaryFloatingPoint
//{
//    static void Main()
//    {
//        Console.Write("Please, enter a floating-point number: ");
//        float number = float.Parse(Console.ReadLine());
//        string binary = ConvertFloatingPointToBynary(number);
//        Console.WriteLine("Binary: {0}", binary);
//        Console.WriteLine("Sign: {0}", binary[0]);
//        Console.WriteLine("Exponent: {0}", binary.Substring(1, 8));
//        Console.WriteLine("Mantissa: {0}", binary.Substring(9, binary.Length - 9));
//    }
//    private static string ConvertFloatingPointToBynary(float number)
//    {
//        char sign = number < 0 ? '1' : '0';
//        if (number == 0)
//        {
//            return Convert.ToString(0, 2).PadLeft(32, '0');
//        }
//        else if (number < 0)
//        {
//            number = number * (-1);
//        }

//        byte[] tempBytes = BitConverter.GetBytes(number);
//        int temp = BitConverter.ToInt32(tempBytes, 0);
//        return sign + Convert.ToString(temp, 2);
//    }
//}