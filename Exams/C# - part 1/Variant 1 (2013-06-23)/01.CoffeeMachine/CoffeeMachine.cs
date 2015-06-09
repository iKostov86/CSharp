using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n1 = 10;    //corresponds to 0.05 BGN
        int n2 = 10;    //corresponds to 0.1 BGN
        int n3 = 10;    //corresponds to 0.2 BGN
        int n4 = 10;    //corresponds to 0.5 BGN
        int n5 = 1;     //corresponds to 1 BGN

        //price P of the selected drink
        decimal price = 1.8m;

        //the amount A the developer has put in the machine
        Console.WriteLine("Please enter amount of coins: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        while (amount < price)
        {
            Console.WriteLine("More, {} BGN needed.", (price - amount));
            amount = decimal.Parse(Console.ReadLine());
        }

        decimal change = amount - price;

        ChekCoins(ref n5, ref change, ref price, 1m);
        ChekCoins(ref n4, ref change, ref price, 0.5m);
        ChekCoins(ref n3, ref change, ref price, 0.2m);
        ChekCoins(ref n2, ref change, ref price, 0.1m);
        ChekCoins(ref n1, ref change, ref price, 0.05m);

        if (change != 0)
        {
            Console.WriteLine("No, the machine can't give change.");
        }
        else
        {
            Console.WriteLine("Yes, left coins are: \r\n{0} x 1BGN, \r\n{1} x 0.5BGN, \r\n{2} x 0.2BGN, \r\n{3} x 0.1BGN, \r\n{4} x 0.05BGN.", n5, n4, n3, n2, n1);
        }
    }

    static void ChekCoins(ref int n, ref decimal change, ref decimal price, decimal coin)
    {
        if (change >= coin)
        {
            int count = (int)(change / coin);
            if (n >= count)
            {
                change -= count * coin;
                n -= count;
            }
            else
            {
                change -= n * coin;
                n = 0;
            }
        }
    }
}
