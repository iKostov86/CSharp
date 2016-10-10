using System;

public class FourDigits
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        char[] digits = num.ToString().ToCharArray();
        double sum = 0;

        foreach (var digit in digits)
        {
            sum += Char.GetNumericValue(digit);
        }

        //Array.Reverse(digits);
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", digits[3], digits[2], digits[1], digits[0]);
        Console.WriteLine("{0}{3}{2}{1}", digits[3], digits[2], digits[1], digits[0]);
        Console.WriteLine("{3}{1}{2}{0}", digits[3], digits[2], digits[1], digits[0]);
        //Console.WriteLine("{0}{1}{2}", sum, Environment.NewLine, new string(digits));
    }
}
