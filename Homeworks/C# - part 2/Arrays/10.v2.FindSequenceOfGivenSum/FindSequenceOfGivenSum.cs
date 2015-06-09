using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] arrayInt = new int[] { 4, 3, 1, 4, 2, 5, 8};
        int givenSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrayInt.Length; i++)
        {
            int tempSum = 0;
            int index = i;
            int count = 0;

            for (int j = i; j < arrayInt.Length; j++)
            {
                tempSum += arrayInt[j];
                count++;
                if (tempSum == givenSum)
                {
                    for (int k = index; k < index + count; k++)
                    {
                        Console.WriteLine("{0} ", arrayInt[k]);
                    }
                    return;
                }
                else if(tempSum > givenSum)
                {
                    break;
                }

            }
        }

        Console.WriteLine("The given sum isn't found");
    }
}
