using System;

public class ArrayAlphabet
{
    internal static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string textStr = Console.ReadLine().ToUpper();
        char[] textArr = textStr.ToCharArray();
        char[] alphabet = new char[90 - 64];

        FillAlphabet(alphabet);
        PrintLetterIndexes(alphabet, textArr);
    }

    public static void FillAlphabet(char[] alphabet)
    {
        for (int i = 0, len = alphabet.Length; i < len; i++)
        {
            alphabet[i] = (char)(65 + i);
        }
    }

    public static void PrintLetterIndexes(char[] alphabet, char[] textArr)
    {
        for (int i = 0, len = textArr.Length; i < len; i++)
        {
            Console.Write("{0} ", Array.BinarySearch(alphabet, textArr[i]) + 1);
        }

        Console.WriteLine();
    }
}
