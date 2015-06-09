using System;

class BonusPoints
{
    static void Main()
    {
        Console.WriteLine("Please enter your points [0:9]");
        byte point = byte.Parse(Console.ReadLine());

        switch (point)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Your result is: {0}", point * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Your result is: {0}", point * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Your result is: {0}", point * 1000);
                break;
            case 0:
            default:
                Console.WriteLine("Error!");
                break;
        }
    }
}
