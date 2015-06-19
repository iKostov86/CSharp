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
        DateTime dateOne = DateTime.Now;
        ReadInput();
        InitializingGame();
        StartGame();
        //Console.WriteLine(DateTime.Now - dateOne);
    }

    public static void ReadInput()
    {
        StringBuilder sb = new StringBuilder();
        int strIndex = 0;

        string[] xyzAsStr = Console.ReadLine().Split(' ');
        initialX = int.Parse(xyzAsStr[0]);
        initialY = int.Parse(xyzAsStr[1]);
        //initialZ = int.Parse(xyzAsStr[2]);

        while (!Char.IsLetter(xyzAsStr[2], strIndex))
        {
            sb.Append(xyzAsStr[2][strIndex]);
            strIndex++;
        }

        initialZ = int.Parse(sb.ToString());
        sb.Remove(0, sb.Length);

        sb.Append(xyzAsStr[2].Substring(strIndex, xyzAsStr[2].Length - strIndex));

        //redMoves = Console.ReadLine();
        //blueMoves = Console.ReadLine();
        redMoves = sb.ToString().Substring(0, sb.Length / 2);
        blueMoves = sb.ToString().Substring((sb.Length / 2), (sb.Length / 2));
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
            if (redMoves.Length != 0)
            {
                while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
                {
                    CalculationDirection(ref redMoves, ref directionRed, ref redIndex);
                    redIndex++;
                }

                MovePlayer(ref currentRedX, ref currentRedY, directionRed);
                redIndex++;
            }
            #endregion

            #region MoveBlue
            if (blueMoves.Length != 0)
            {
                while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
                {
                    CalculationDirection(ref blueMoves, ref directionBlue, ref blueIndex);
                    blueIndex++;
                }
                MovePlayer(ref currentBlueX, ref currentBlueY, directionBlue);
                blueIndex++;
            }
            #endregion

            #region Loses
            bool redLoses = Loses(currentRedX, currentRedY);
            bool blueLoses = Loses(currentBlueX, currentBlueY);

            if (redLoses && blueLoses)
            {
                Console.Write("DRAW");
                StartEndDistance(-1);
                break;
            }
            else if (redLoses)
            {
                Console.Write("BLUE");
                if (currentRedX == 0 || currentRedX == initialX)
                {
                    StartEndDistance(-1);
                }
                else
                {
                    StartEndDistance(0);
                }
                break;
            }
            else if (blueLoses)
            {
                Console.Write("RED");
                if (currentBlueX == 0 || currentBlueX == initialX)
                {
                    StartEndDistance(-1);
                }
                else
                {
                    StartEndDistance(0);
                }
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
        if (currentX < 0 || currentX > newX || used[currentX, currentY])
        {
            return true;
        }

        return false;
    }

    public static void StartEndDistance(int coefficient)
    {
        int distanceX = Math.Abs((initialX / 2) - currentRedX);
        int distanceY1 = newY - (initialY / 2) + currentRedY;
        int distanceY2 = Math.Abs((initialY / 2) - currentRedY);

        Console.Write(distanceX + Math.Min(distanceY1, distanceY2) + coefficient);
    }
}