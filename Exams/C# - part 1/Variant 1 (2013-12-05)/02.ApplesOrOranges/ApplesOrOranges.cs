using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ApplesOrOranges
{
    static void Main()
    {
        string number = Console.ReadLine();
        int even = 0;
        int odd = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if ((i % 2) == 0)
            {
                odd += int.Parse(number[i].ToString());
            }
            else
            {
                even += int.Parse(number[i].ToString());
            }
        }

        if (even > odd)
        {
            Console.WriteLine("apples " + even);
        }
        else if (odd > even)
        {
            Console.WriteLine("oranges " + odd);
        }
        else
        {
            Console.WriteLine("both " + even);
        }
    }
}
