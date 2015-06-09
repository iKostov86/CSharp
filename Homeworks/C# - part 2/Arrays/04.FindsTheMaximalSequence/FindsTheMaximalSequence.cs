using System;

class FindsTheMaximalSequence
{
    static void Main()
    {
        int[] arrayOfChars = new int[12] { 2, 2, 7, 2, 2, 2, 7, 9, 9, 9, 9, 9 };
        //int[] firstArray = new int[firstString.Length];
        //Random rand = new Random();
        int bestIndex = 0;
        int bestReps = 1;
        int tempReps = 1;

        //for (int i = 0; i < firstArray.Length; i++)
        //{
        //    firstArray[i] = rand.Next(0, 11);
        //}

        for (int i = 1; i < arrayOfChars.Length; i++ )
        {
            if (arrayOfChars[i] == arrayOfChars[i - 1])
            {
                tempReps++;
                if (i != arrayOfChars.Length - 1)
                {
                    
                }
                if(tempReps > bestReps)
                {
                    bestIndex = i - tempReps + 1;
                    bestReps = tempReps;
                }
            }
            else
            {
                if (tempReps > bestReps)
                {
                    bestIndex = i - tempReps + 1;
                    bestReps = tempReps;
                }
                tempReps = 1;
            }
        }

        for (int i = bestIndex; i < bestIndex + bestReps; i++)
        {
            Console.WriteLine(arrayOfChars[i]);
        }
    }
}
