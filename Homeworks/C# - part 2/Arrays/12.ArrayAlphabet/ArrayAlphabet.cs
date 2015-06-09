using System;
using System.Text;

class ArrayAlphabet
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char[] alphabet = new char[90 - 64];
        //Console.WriteLine(alphabet.Length);
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(65 + i);
            //Console.WriteLine(alphabet[i]);
        }
        string textString = Console.ReadLine();
        char[] textChar = textString.ToCharArray();
        for (int i = 0; i < textChar.Length; i++)
        {
            Console.WriteLine(Array.BinarySearch(alphabet, textChar[i]) + " ");
        }
    }
}
