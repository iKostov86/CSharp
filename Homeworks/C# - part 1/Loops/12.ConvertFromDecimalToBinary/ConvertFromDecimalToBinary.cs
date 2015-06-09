using System;
using System.Collections.Generic;

class ConvertFromDecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number: ");
        int numDecimal = int.Parse(Console.ReadLine());
        List<int> numBinary = new List<int>();

        while (numDecimal > 0)
        {
            numBinary.Add(numDecimal % 2);
            numDecimal /= 2;
        }

        for (int i = numBinary.Count -1; i > -1; i--)
        {
            Console.Write("{0}", numBinary[i]);
        }

        Console.WriteLine();
    }
}
