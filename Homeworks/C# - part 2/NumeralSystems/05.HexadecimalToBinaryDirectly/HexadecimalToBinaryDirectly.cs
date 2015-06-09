using System;
using System.Text;

class HexadecimalToBinaryDirectly
{
    static void Main()
    {
        string hexaNum = Console.ReadLine();
        ConvertHexadecimalToBinaryDirectly(hexaNum);
    }

    static void ConvertHexadecimalToBinaryDirectly(string number)
    {
        StringBuilder binList = new StringBuilder("0b");

        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case 'A': binList.Append(" 1010"); break;
                case 'B': binList.Append(" 1011"); break;
                case 'C': binList.Append(" 1100"); break;
                case 'D': binList.Append(" 1101"); break;
                case 'E': binList.Append(" 1110"); break;
                case 'F': binList.Append(" 1111"); break;
                case '0': binList.Append(" 0000"); break;
                case '1': binList.Append(" 0001"); break;
                case '2': binList.Append(" 0010"); break;
                case '3': binList.Append(" 0011"); break;
                case '4': binList.Append(" 0100"); break;
                case '5': binList.Append(" 0101"); break;
                case '6': binList.Append(" 0110"); break;
                case '7': binList.Append(" 0111"); break;
                case '8': binList.Append(" 1000"); break;
                case '9': binList.Append(" 1001"); break;
            }
        }
        PrintConvertedNumber(binList);
    }

    static void PrintConvertedNumber(StringBuilder list)
    {
        Console.WriteLine(list);
    }
}
