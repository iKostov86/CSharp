using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DrunkenNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number of rounds: ");
        int numbersOfRounds = int.Parse(Console.ReadLine());
        Console.Clear();

        int firstPlayer = 0;
        int secondPlayer = 0;

        for (int n = 0; n < numbersOfRounds; n++)
        {
            Console.WriteLine("Enter a drunken number: ");
            string temp = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < temp.Length / 2; i++)
            {
                firstPlayer += int.Parse(temp[i].ToString());
            }

            for (int j = temp.Length - 1; j > temp.Length - (temp.Length / 2) - 1; j--)
			{
                secondPlayer += int.Parse(temp[j].ToString());
			}

            if ((temp.Length % 2) != 0)
            {
            //the number is odd
                firstPlayer += int.Parse(temp[temp.Length / 2].ToString());
                secondPlayer += int.Parse(temp[temp.Length / 2].ToString());
            }
        }

        if (firstPlayer > secondPlayer)
        {
            Console.WriteLine("Mitko - {0} beers.", firstPlayer);
        }
        else
        {
            Console.WriteLine("Vlado - {0} beers.", secondPlayer);
        }
    }
}
