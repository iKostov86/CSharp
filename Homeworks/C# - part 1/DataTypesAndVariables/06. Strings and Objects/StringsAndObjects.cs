using System;

public class StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstStr = "Hello";
        string secondStr = "World!";
        string fullStr = string.Empty;
        object container = firstStr + " " + secondStr;

        fullStr = (string)container;

        Console.WriteLine(fullStr);
    }
}
