using System;

class DrunkenNumbers
{
    static void Main()
    {
        int numbersOfRounds = int.Parse(Console.ReadLine());

        int vladko = 0;

        int mitko = 0;

        for (int n = 0; n < numbersOfRounds; n++)
        {
            int givenNum = int.Parse(Console.ReadLine());

            if (givenNum < 0)
            {
                givenNum = -givenNum;
            }

            string givenNumAsStr = givenNum.ToString();

            int length = givenNumAsStr.Length;

            for (int i = 0, j = length - 1; i < length / 2; i++, j--)
            {
                mitko += int.Parse(givenNumAsStr[i].ToString());
                vladko += int.Parse(givenNumAsStr[j].ToString());
            }

            if (length % 2 != 0)
            {
                mitko += int.Parse(givenNumAsStr[length / 2].ToString());
                vladko += int.Parse(givenNumAsStr[length / 2].ToString());
            }
        }

        PrintResult(vladko, mitko);
    }

    public static void PrintResult(int vladko, int mitko)
    {
        if (vladko > mitko)
        {
            Console.WriteLine("V {0}", vladko - mitko);
        }
        else if (mitko > vladko)
        {
            Console.WriteLine("M {0}", mitko - vladko);
        }
        else
        {
            Console.WriteLine("No {0}", vladko + mitko);
        }
    }
}
