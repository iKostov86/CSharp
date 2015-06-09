using System;
using System.Text;

class BinaryToHexadecimalDirectly
{
    static void Main()
    {
        string binNum = Console.ReadLine();
        ConvertBinaryToHexadecimalDirectly(binNum);
    }

    static void ConvertBinaryToHexadecimalDirectly(string number)
    {
        StringBuilder hexList = new StringBuilder("0x");

        if (number.Length % 4 != 0)
        {
            int zeros = 4 - (number.Length % 4);
            switch (zeros)
            {
                case 1:
                    number = "0" + number;
                    break;
                case 2:
                    number = "00" + number;
                    break;
                case 3:
                    number = "000" + number;
                    break;
            }
        }

        for (int i = 0; i < number.Length; i += 4)
        {
            switch (number.Substring(i, 4))
            {
                case "1010": hexList.Append('A'); break;
                case "1011": hexList.Append('B'); break;
                case "1100": hexList.Append('C'); break;
                case "1101": hexList.Append('D'); break;
                case "1110": hexList.Append('E'); break;
                case "1111": hexList.Append('F'); break;
                case "0000": hexList.Append('0'); break;
                case "0001": hexList.Append('1'); break;
                case "0010": hexList.Append('2'); break;
                case "0011": hexList.Append('3'); break;
                case "0100": hexList.Append('4'); break;
                case "0101": hexList.Append('5'); break;
                case "0110": hexList.Append('6'); break;
                case "0111": hexList.Append('7'); break;
                case "1000": hexList.Append('8'); break;
                case "1001": hexList.Append('9'); break;
            }
        }
        PrintConvertedNumber(hexList);
    }

    static void PrintConvertedNumber(StringBuilder list)
    {
        Console.WriteLine(list);
    }
}