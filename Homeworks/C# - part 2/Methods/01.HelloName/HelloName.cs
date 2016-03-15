using System;

public class HelloName
{
    internal static void Main()
    {
        string name = string.Empty;

        while (name == string.Empty)
        {
            Console.WriteLine("Please, enter your name!");
            name = Console.ReadLine();
        }

        PrintTextToConsole(name);
    }

    static void PrintTextToConsole(string text)
    {
        Console.WriteLine("Hello, " + text + "!");
    }
}
