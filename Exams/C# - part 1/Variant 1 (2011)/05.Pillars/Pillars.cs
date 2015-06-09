using System;

class Pillars
{
    static void Main()
    {
        int n0 = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int n6 = int.Parse(Console.ReadLine());
        int n7 = int.Parse(Console.ReadLine());
        int fullCellsLeft = 0;
        int fullCellsRight = 0;
        int pillarNum = 0;
        bool pillarExists = false;
        int mask = 0;

        for (int pillarTemp = 7; pillarTemp > -1; pillarTemp--)
        {
            fullCellsLeft = 0;
            fullCellsRight = 0;

            mask = 1;
            for (int colLeft = pillarTemp + 1; colLeft < 8; colLeft++)
            {
                mask <<= colLeft;
                fullCellsLeft += (n0 & mask) >> colLeft;
                fullCellsLeft += (n1 & mask) >> colLeft;
                fullCellsLeft += (n2 & mask) >> colLeft;
                fullCellsLeft += (n3 & mask) >> colLeft;
                fullCellsLeft += (n4 & mask) >> colLeft;
                fullCellsLeft += (n5 & mask) >> colLeft;
                fullCellsLeft += (n6 & mask) >> colLeft;
                fullCellsLeft += (n7 & mask) >> colLeft;
                mask = 1;
            }
            for (int colRight = pillarTemp - 1; colRight > -1; colRight--)
            {
                mask <<= colRight;
                fullCellsRight += (n0 & mask) >> colRight;
                fullCellsRight += (n1 & mask) >> colRight;
                fullCellsRight += (n2 & mask) >> colRight;
                fullCellsRight += (n3 & mask) >> colRight;
                fullCellsRight += (n4 & mask) >> colRight;
                fullCellsRight += (n5 & mask) >> colRight;
                fullCellsRight += (n6 & mask) >> colRight;
                fullCellsRight += (n7 & mask) >> colRight;
                mask = 1;
            }
            if (fullCellsLeft == fullCellsRight)
            {
                pillarExists = true;
                pillarNum = pillarTemp;
                break;
            }
        }
        if (pillarExists == true)
        {
            Console.WriteLine(pillarNum);
            Console.WriteLine(fullCellsLeft);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

