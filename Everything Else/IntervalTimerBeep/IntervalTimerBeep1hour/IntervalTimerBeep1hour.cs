using System;

class IntervalTimerBeep1hour
{
    static void Main()
    {
        for (int i = 0; i < 3600; i++)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Write("{0}\r", i);
        }

        for (int j = 0; j < 100; j++)
        {
            System.Threading.Thread.Sleep(1500);
            Console.Beep();

        }
    }
}
