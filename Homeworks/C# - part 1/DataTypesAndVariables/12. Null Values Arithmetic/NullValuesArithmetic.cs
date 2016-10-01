using System;

public class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? wholeNum = null;
        double? realNum = null;

        Console.WriteLine("|{0} <-> {1}|", wholeNum + 7, realNum + 7);
        Console.WriteLine("|{0} <-> {1}|", wholeNum + null, realNum + null);

        Console.WriteLine(wholeNum.GetValueOrDefault());
        Console.WriteLine(wholeNum.GetValueOrDefault() + 7);
        Console.WriteLine(realNum.GetValueOrDefault());
        Console.WriteLine(realNum.GetValueOrDefault() + 7.5);
    }
}
