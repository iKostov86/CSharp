using System;
using System.Collections.Generic;

class FindsTheMaximalSequence
{
    static void Main()
    {
        //digits from 0 to 9
        string inputString = Console.ReadLine();
        char[] charMassive = inputString.ToCharArray();
        int startPosition = 0;
        int newStart = 0;
        int endPosition = 0;
        int newEnd = 0;

        for (int i = 1; i < charMassive.Length; i++)
        {
            if (charMassive[i] == charMassive[i - 1] + 1)
            {
                newEnd++;
                if (i != charMassive.Length - 1)
                {
                    continue;
                }
                else if (newEnd > endPosition)
                {
                    startPosition = newStart;
                    endPosition = newEnd;
                }
            }
            else
            {
                if (newEnd > endPosition)
                {
                    startPosition = newStart;
                    endPosition = newEnd;
                }
                newStart = i;
                newEnd = 0;
            }
        }

        for (int i = startPosition; i < startPosition + endPosition + 1; i++)
        {
            Console.WriteLine(charMassive[i]);
        }
    }
}


