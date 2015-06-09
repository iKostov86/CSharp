using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        int[] mas = new int[5];

        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(mas[i]);
        }

        int temp = 0; ;

        for (int j = 0; j < mas.Length; j++)
        {
            if (temp < mas[j])
            {
                temp = mas[j];
            }
        }

        Console.WriteLine();
        Console.WriteLine(temp);
    }
}
