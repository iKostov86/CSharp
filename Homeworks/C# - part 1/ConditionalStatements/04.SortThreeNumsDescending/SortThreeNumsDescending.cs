using System;

class SortThreeNumsDescending
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double temp;

        if (a < b && a < c)
        {
            temp = a;
            a = c;
            c = temp;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
        }
        else if (a > b && a > c)
        {
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }
        else if (a > b && a < c)
        {
            temp = a;
            a = c;
            c = temp;
            temp = b;
            b = c;
            c = temp;
        }
        else
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("\n{0}\n{1}\n{2}\n", a , b , c);


        //if (b > a)
        //{
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}
        //if (c > a)
        //{
        //    temp = a;
        //    a = c;
        //    c = temp;
        //}
        //if (c > b)
        //{
        //    temp = c;
        //    c = b;
        //    b = temp;
        //}

        //Console.WriteLine("{0},{1},{2}", var1, var2, var3);

    }
}