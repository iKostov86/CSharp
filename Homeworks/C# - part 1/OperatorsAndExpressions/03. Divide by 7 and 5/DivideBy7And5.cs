using System;

public class DivideBy7And5
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        bool state;

        state = (num % 7 == 0 && num % 5 == 0) ? true : false;

        Console.WriteLine("{0} {1}", state.ToString().ToLower(), num);
    }
}