using System;

class TranslateDigitInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Please enter a digit between 0 - 9: ");
        Console.WriteLine();
        byte digit = byte.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (digit)
        {
            case 0:
                Console.WriteLine("Нула");
                break;
            case 1:
                Console.WriteLine("Едно");
                break;
            case 2:
                Console.WriteLine("Две");
                break;
            case 3:
                Console.WriteLine("Три");
                break;
            case 4:
                Console.WriteLine("Четири");
                break;
            case 5:
                Console.WriteLine("Пет");
                break;
            case 6:
                Console.WriteLine("Шест");
                break;
            case 7:
                Console.WriteLine("Седем");
                break;
            case 8:
                Console.WriteLine("Осем");
                break;
            case 9:
                Console.WriteLine("Девет");
                break;
            default:
                Console.WriteLine("Invalid digit!");
                break;
        }
        Console.WriteLine();
    }
}
