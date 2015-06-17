using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tron3D
{
    static int initialX, initialY, initialZ;
    static int newX, newY;
    static string redMoves, blueMoves;
    static bool[,] used;
    static int currentRedX;
    static int currentRedY;
    static int currentBlueX;
    static int currentBlueY;
    static int directionRed;
    static int directionBlue;

    static void Main()
    {
        ReadInput();
        InitializingGame();
        StartGame();
    }

    public static void ReadInput()
    {
        string[] xyzAsStr = Console.ReadLine().Split(' ');
        initialX = int.Parse(xyzAsStr[0]);
        initialY = int.Parse(xyzAsStr[1]);
        initialZ = int.Parse(xyzAsStr[2]);

        redMoves = Console.ReadLine();
        blueMoves = Console.ReadLine();
    }

    public static void InitializingGame()
    {
        newX = initialX;
        newY = (initialY * 2) + (initialZ * 2);

        used = new bool[newX + 1, newY];

        currentRedX = initialX / 2;
        currentRedY = initialY / 2;
        currentBlueX = initialX / 2;
        currentBlueY = initialY + (initialY / 2) + initialZ;

        directionRed = 0;
        directionBlue = 2;
    }

    public static void StartGame()
    {
        int redIndex = new int();
        int blueIndex = new int();

        while (true)
        {
            #region MoveRed
            while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
            {
                CalculationDirection(ref redMoves, ref directionRed, ref redIndex);
                redIndex++;
            }

            MovePlayer(ref currentRedX, ref currentRedY, directionRed);
            redIndex++;
            #endregion

            #region MoveBlue
            while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
            {
                CalculationDirection(ref blueMoves, ref directionBlue, ref blueIndex);
                blueIndex++;
            }

            MovePlayer(ref currentBlueX, ref currentBlueY, directionBlue);
            blueIndex++;
            #endregion

            #region Loses
            bool redLoses = Loses(currentRedX, currentRedY);
            bool blueLoses = Loses(currentBlueX, currentBlueY);

            if (redLoses && blueLoses)
            {
                Console.WriteLine("DRAW");
                break;
            }
            else if (redLoses)
            {
                Console.WriteLine("BLUE");
                break;
            }
            else if (blueLoses)
            {
                Console.WriteLine("RED");
                break;
            }
            #endregion

            used[currentRedX, currentRedY] = true;
            used[currentBlueX, currentBlueY] = true;
        }
    }

    public static void CalculationDirection(ref string moves, ref int direction, ref int index)
    {
        if (moves[index] == 'R')
        {
            direction++;
        }
        else if (moves[index] == 'L')
        {
            direction--;
        }

        if (direction == 4)
        {
            direction = 0;
        }
        else if (direction == -1)
        {
            direction = 3;
        }
    }

    public static void MovePlayer(ref int currentX, ref int currentY, int direction)
    {
        if (direction == 0)
        {
            currentY++;
        }
        else if (direction == 1)
        {
            currentX++;
        }
        else if (direction == 2)
        {
            currentY--;
        }
        else
        {
            currentX--;
        }

        if (currentY == newY)
        {
            currentY = 0;
        }
        else if (currentY < 0)
        {
            currentY = newY - 1;
        }
    }

    public static bool Loses(int currentX, int currentY)
    {
        if (used[currentX, currentY] || currentX < 0 || currentX > newX)
        {
            return true;
        }

        return false;
    }
}
