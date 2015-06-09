using System;

class BinaryToDecimal
{
    static void Main()
    {
        int[] binArray = new int[] { 1, 0, 1, 1 };
        ConvertBinaryToDecimal(binArray);
    }

    static void ConvertBinaryToDecimal(int[] array)
    {
        int decNum = new int();
        double pow = 0;
        for (int i = array.Length - 1; i > -1; i--)
        {
            decNum += array[i] * (int)(Math.Pow(2, pow));
            pow++;
        }
        Console.WriteLine(decNum);
    }
}
