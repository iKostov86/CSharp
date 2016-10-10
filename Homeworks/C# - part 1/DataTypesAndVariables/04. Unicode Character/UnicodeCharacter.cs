using System;

public class UnicodeCharacter
{
    static void Main(string[] args)
    {
        int decimalRepresentation = 42;
        string hexadecimalRepresentationAsStr = decimalRepresentation.ToString("x");
        int hexadecimalRepresentation = int.Parse(hexadecimalRepresentationAsStr, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine(hexadecimalRepresentationAsStr);
    }
}
