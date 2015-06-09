using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EasterMister
{
    static void Main()
    {
        int number = 12;
        int heightOfEgg = 2 * number;                   //8
        int widthOfTheEgg = 3 * number - 1;             //11
        int widthOfTheDrawingArea  = 3 * number + 1;    //13
        int bottomAndTopSizeOffEgg = number - 1;         //3

        PrintTopToMiddle(number, heightOfEgg, widthOfTheEgg, widthOfTheDrawingArea, bottomAndTopSizeOffEgg);
        PrintRiboon(number, heightOfEgg, widthOfTheEgg, widthOfTheDrawingArea, bottomAndTopSizeOffEgg);
        PrintMiddleToBottom(number, heightOfEgg, widthOfTheEgg, widthOfTheDrawingArea, bottomAndTopSizeOffEgg);
        Console.WriteLine();
    }

    static void PrintTopToMiddle(int number, int heightOfEgg, int widthOfTheEgg, int widthOfTheDrawingArea, int bottomAndTopSizeOffEgg)
    {
        PrintTopAndBottom(number, heightOfEgg, widthOfTheEgg, widthOfTheDrawingArea, bottomAndTopSizeOffEgg);

        for (int i = number - 1; i > 0; i -= 2)
        {
            for (int j = 0; j < widthOfTheDrawingArea; j++)
            {
                if (j == i || j == widthOfTheDrawingArea - i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintMiddleToBottom(int number, int heightOfEgg, int widthOfTheEgg, int widthOfTheDrawingArea, int bottomAndTopSizeOffEgg)
    {
        for (int i = 1; i < number; i += 2)
        {
            for (int j = 0; j < widthOfTheDrawingArea; j++)
            {
                if (j == i || j == widthOfTheDrawingArea - i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        PrintTopAndBottom(number, heightOfEgg, widthOfTheEgg, widthOfTheDrawingArea, bottomAndTopSizeOffEgg);
    }

    static void PrintTopAndBottom(int number, int heightOfEgg, int widthOfTheEgg, int widthOfTheDrawingArea, int bottomAndTopSizeOffEgg)
    {
        for (int i = 0; i < widthOfTheDrawingArea; i++)
        {
            if (i < number + 1 || i > 2 * number - 1)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }

    static void PrintRiboon(int number, int heightOfEgg, int widthOfTheEgg, int widthOfTheDrawingArea, int bottomAndTopSizeOffEgg)
    {
        for (int i = 0; i < widthOfTheDrawingArea; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else if (i == 1 || i == widthOfTheDrawingArea - 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("#");
            }
        }

        Console.WriteLine();

        for (int i = 0; i < widthOfTheDrawingArea; i++)
        {
            if (i == 0 || i == widthOfTheDrawingArea - 1)
            {
                Console.Write(".");
            }
            else if (i == 1 || i == widthOfTheDrawingArea - 2)
            {
                Console.Write("*");
            }
            else if (i % 2 != 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine();
    }
}
