using System;

class ChoiseOfInputData
{
    static void Main()
    {
        Console.WriteLine("Please enter your data choise: 1 to Integer, 2 to Double or 3 to String. ");
        byte choise = byte.Parse(Console.ReadLine());
        
        switch (choise)
        {
            case 1:
                Console.WriteLine("Please enter your integer: ");
                int num = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(num);
                break;
            case 2:
                Console.WriteLine("Please enter your real number:");
                double real = double.Parse(Console.ReadLine()) + 1.0;
                Console.WriteLine(real);
                break;
            case 3:
                Console.WriteLine("Please enter your string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                Console.WriteLine("Invalid choise!");
                break;
        }
    }
}
