using System;
using System.Globalization;
using System.Threading;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n1 = int.Parse(Console.ReadLine());    //corresponds to 0.05 BGN
        int n2 = int.Parse(Console.ReadLine());    //corresponds to 0.1 BGN
        int n3 = int.Parse(Console.ReadLine());    //corresponds to 0.2 BGN
        int n4 = int.Parse(Console.ReadLine());    //corresponds to 0.5 BGN
        int n5 = int.Parse(Console.ReadLine());     //corresponds to 1 BGN

        decimal developerMoney = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        decimal change = developerMoney - drinkPrice;
        decimal moneyInMachine = n5 * 1m + n4 * 0.5m + n3 * 0.2m + n2 * 0.1m + n1 * 0.05m; ;

        if (change < 0)
        {
            Console.WriteLine("More {0}", -change);
        }
        else
        {
            if (change <= moneyInMachine)
            {
                Console.WriteLine("Yes {0}", moneyInMachine - change);
            }
            else
            {
                Console.WriteLine("No {0}", change - moneyInMachine);
            }
        }
    }
}

//ChekCoins(ref n5, ref change, ref price, 1m);
//ChekCoins(ref n4, ref change, ref price, 0.5m);
//ChekCoins(ref n3, ref change, ref price, 0.2m);
//ChekCoins(ref n2, ref change, ref price, 0.1m);
//ChekCoins(ref n1, ref change, ref price, 0.05m);

//static void ChekCoins(ref int n, ref decimal change, ref decimal price, decimal coin)
//{
//    if (change >= coin)
//    {
//        int count = (int)(change / coin);
//        if (n >= count)
//        {
//            change -= count * coin;
//            n -= count;
//        }
//        else
//        {
//            change -= n * coin;
//            n = 0;
//        }
//    }
//}
