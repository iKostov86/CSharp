using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class CalculateSumFromStringOfPositiveInt
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder number = new StringBuilder();
        List<int> result = new List<int>();
        int sum = new int();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                number.Append(input[i]);
            }
            else
            {
                result.Add(Convert.ToInt32(number.ToString()));
                number.Clear();
            }
        }

        if (number.ToString() != string.Empty)
        {
            result.Add(Convert.ToInt32(number.ToString()));
            number.Clear();
        }

        foreach (var item in result)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}
