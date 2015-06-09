using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        float sumOld = 0f;
        float sumNew = 1f;
        float i = 2f;

        do
        {
            if (i % 2 == 0)
            {
                sumOld = sumNew;
                sumNew += 1 / i;
                i++;
            }
            else
            {
                sumOld = sumNew;
                sumNew -= 1 / i;
                i++;
            }
        } while (Math.Abs(sumNew - sumOld) > 0.001);

        Console.WriteLine("The new sum is: {0}\n\rThe old sum is: {1}\n\rThe divider is: {2}", sumNew, sumOld, i);
    }
}
