using System;

class MultiverseCommunication
{
    static void Main()
    {
        string input = string.Empty;

        while ((input.Length / 3) > 9 || (input.Length / 3) < 1)
        {
            input = Console.ReadLine();
        }

        int number = new int();
        int multi = (int)Math.Pow(13.0, (input.Length / 3) - 1);

        for (int i = 0; i < input.Length; i += 3)
        {
            string subStr = input.Substring(i, 3);
            number += StringToDecimal(subStr) * multi;
            multi /= 13;
        }

        Console.WriteLine(number);
    }

    public static int StringToDecimal(string input)
    {
        int a = new int();

        switch (input)
        {
            case "CHU":
                a = 0;
                break;
            case "TEL":
                a = 1;
                break;
            case "OFT":
                a = 2;
                break;
            case "IVA":
                a = 3;
                break;
            case "EMY":
                a = 4;
                break;
            case "VNB":
                a = 5;
                break;
            case "POQ":
                a = 6;
                break;
            case "ERI":
                a = 7;
                break;
            case "CAD":
                a = 8;
                break;
            case "K-A":
                a = 9;
                break;
            case "IIA":
                a = 10;
                break;
            case "YLO":
                a = 11;
                break;
            case "PLA":
                a = 12;
                break;
            default:
                break;
        }

        return a;
    }
}
