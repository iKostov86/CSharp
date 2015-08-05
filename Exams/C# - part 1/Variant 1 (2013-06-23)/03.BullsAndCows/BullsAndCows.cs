using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();

        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        List<string> listOfNums = new List<string>();

        //get guess number
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int m = 1; m <= 9; m++)
                    {
                        string guessNumber = string.Format("{0}{1}{2}{3}", i, j, k, m);
                        bool[] secretBusyPosition = new bool[4];
                        bool[] guessBusyPosition = new bool[4];
                        int tempBulls = 0;
                        int tempCows = 0;

                        //get bulls
                        for (int n = 0; n < 4; n++)
                        {
                            if (guessNumber[n] == secretNumber[n])
                            {
                                tempBulls++;
                                secretBusyPosition[n] = true;
                                guessBusyPosition[n] = true;
                            }
                        }

                        //get cows
                        for (int p = 0; p < 4; p++)
                        {
                            for (int q = 0; q < 4; q++)
                            {
                                if (p != q
                                    && secretBusyPosition[q] == false
                                        && guessBusyPosition[p] == false
                                            && guessNumber[p] == secretNumber[q])
                                {
                                    tempCows++;
                                    secretBusyPosition[q] = true;
                                    guessBusyPosition[p] = true;
                                }
                            }
                        }

                        //chek if temp results are the same like the given ones
                        if ((tempBulls == bulls) && (tempCows == cows))
                        {
                            listOfNums.Add(guessNumber);
                        }
                    }
                }
            }
        }

        if (listOfNums.Count != 0)
        {
            Console.WriteLine(String.Join(" ", listOfNums));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}