using System;

class SignOfAProductOfThreeNumbers
{
    static void Main()
    {
        int a = -3;
        int b = -5;
        int c = -22;
        bool signPossitive = true;

        if (a < 0)
        {
            signPossitive = !signPossitive;
            if (b < 0)
            {
                signPossitive = !signPossitive;
                if (c < 0)
                {
                    signPossitive = !signPossitive;
                }
            }
        }

        if (signPossitive)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
