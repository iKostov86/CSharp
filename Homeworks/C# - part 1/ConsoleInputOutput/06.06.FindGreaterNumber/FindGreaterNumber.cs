using System;

class FindGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter two integers:");
        string input = Console.ReadLine();
        int a = int.Parse(input);
        input = Console.ReadLine();
        int b = int.Parse(input);
        Console.WriteLine(Math.Max(a, b));
    }
}
