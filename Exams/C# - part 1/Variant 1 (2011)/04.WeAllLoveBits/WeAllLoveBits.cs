using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int p = 0;

            while (num > 0)
            {
                p <<= 1;

                if ((num & 1) == 1)
                {
                    p |= 1;
                }

                num >>= 1;
            }

            Console.WriteLine(p);
        }
    }
}

