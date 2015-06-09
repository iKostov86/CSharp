using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexaNum = Console.ReadLine();
        ConvertHexadecimalToDecimal(hexaNum);
    }

    static void ConvertHexadecimalToDecimal(string number)
    {
        int decNum = 0;
        int multiplier = 1;
        double pow = 0;
        for (int i = number.Length - 1; i > -1; i--)
        {
            switch (number[i])
            {
                case 'A':
                case 'a':
                    multiplier = 10;
                    break;
                case 'B':
                case 'b':
                    multiplier = 11;
                    break;
                case 'C':
                case 'c':
                    multiplier = 12;
                    break;
                case 'D':
                case 'd':
                    multiplier = 13;
                    break;
                case 'E':
                case 'e':
                    multiplier = 14;
                    break;
                case 'F':
                case 'f':
                    multiplier = 15;
                    break;
                default:
                    multiplier = int.Parse(number[i].ToString());
                    break;
            }
            decNum += multiplier * (int)(Math.Pow(16, pow));
            pow++;
        }
        Console.WriteLine(decNum);
    }
}