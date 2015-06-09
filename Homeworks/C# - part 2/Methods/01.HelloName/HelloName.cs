using System;

class HelloName
{
    static void Main()
    {
        string name = "";
        while (name == "")
        {
            Console.WriteLine("Please, enter your name!");
            name = Console.ReadLine();
        }
        Console.WriteLine();
        PrintName(name);
    }

    static void PrintName(string print)
    {
        Console.WriteLine("Hello, " + print + "!");
    }
}
