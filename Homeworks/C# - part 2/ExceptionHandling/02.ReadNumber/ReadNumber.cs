using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadNumber
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumberMethod(start, end);
    }

    public static void ReadNumberMethod(int start, int end)
    {
        Console.WriteLine("Please enter ten numbers, each next is bigger than previos.");

        int numberA = new int();
        int numberB = int.MinValue;

        try
        {
            for (byte i = 0; i < 10; i++)
            {
                numberA = int.Parse(Console.ReadLine());
                if (numberA <= numberB || numberA < start || numberA > end)
                {
                    throw new OverflowException();
                }
                else
                {
                    numberB = numberA;
                }
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Inavalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Inavalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Inavalid number!");
        }
    }
}
