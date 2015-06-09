using System;
using System.Threading;

class JustPingPong
{
    static int ballPositionX = 0;
    static int ballPositionY = 0;
    static bool ballDirectionUp = true;
    static bool ballDirectionRight = true;
    static int firstPlayerPosition = 0;
    static int secondPlayerPosition = 0;
    static int firstPlayerPadSize = 6;
    static int secondPlayerPadSize = 8;
    static int firstPlayerPoint = 0;
    static int secondPlayerPoint = 0;
    static Random randomGenerator = new Random();
    static string firstPlayerWins = "First player wins!";
    static string secondPlayerWins = "Second player wins!";

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void SetInitialPosition()
    {
        firstPlayerPosition = (Console.WindowHeight - firstPlayerPadSize) / 2;
        secondPlayerPosition = (Console.WindowHeight - secondPlayerPadSize) / 2;
    }

    static void SetBallAtTheMiddleOfGameField()
    {
        ballPositionX = Console.WindowWidth / 2;
        ballPositionY = Console.WindowHeight / 2;
    }

    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    /** Move all ****************************************************************************************************************************************/

    static void MoveFirstPlayerUp()
    {
        //TODO: move first player up
        if (firstPlayerPosition - 1 >= 0)
        {
            firstPlayerPosition--;
        }
    }

    static void MoveFirstPlayerDown()
    {
        //TODO: move first player down
        if (firstPlayerPosition <= Console.WindowHeight - firstPlayerPadSize - 1)
        {
            firstPlayerPosition++;
        }
    }

    static void SecondPlayerAIMove()
    {
        int randomNumber = randomGenerator.Next(0, 100);
        if (randomNumber > 5)                              //Move is correct
        {
            if (ballDirectionUp == true)
            {
                MoveSecondPlayerUp();
            }
            else
            {
                MoveSecondPlayerDown();
            }
        }
        if (randomNumber < 2)                               //Move is wrong
        {
            if (ballDirectionUp == true)
            {
                MoveSecondPlayerDown();
            }
            else
            {
                MoveSecondPlayerUp();
            }
        }
        //No movement
    }

    static void MoveSecondPlayerUp()
    {
        //TODO: move second player up
        if (secondPlayerPosition - 1 >= 0)
        {
            secondPlayerPosition--;
        }
    }

    static void MoveSecondPlayerDown()
    {
        //TODO: move Second player down
        if (secondPlayerPosition <= Console.WindowHeight - secondPlayerPadSize - 1)
        {
            secondPlayerPosition++;
        }
    }

    static void MoveBall()
    {
        if (ballPositionY == 0)
        {
            ballDirectionUp = false;
        }
        if (ballPositionY == Console.WindowHeight - 1)
        {
            ballDirectionUp = true;
        }

        if (ballPositionX == 0)
        {
            SetBallAtTheMiddleOfGameField();
            secondPlayerPoint++;
            ballDirectionRight = true;
            Console.SetCursorPosition((Console.WindowWidth - secondPlayerWins.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(secondPlayerWins);
            Console.ReadKey();
            // TODO: //ballDirectionRight = true;
        }
        if (ballPositionX < 3)
        {
            if ((ballPositionY >= firstPlayerPosition)
                && (ballPositionY < firstPlayerPosition + firstPlayerPadSize))
            {
                ballDirectionRight = true;
            }
        }
        if (ballPositionX == Console.WindowWidth - 1)
        {
            SetBallAtTheMiddleOfGameField();
            firstPlayerPoint++;
            ballDirectionRight = false;
            Console.SetCursorPosition((Console.WindowWidth - firstPlayerWins.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(firstPlayerWins);
            Console.ReadKey();
            // TODO: //ballDirectionRight = false;
        }
        if (ballPositionX > Console.WindowWidth - 3 - 1)
        {
            if ((ballPositionY >= secondPlayerPosition)
                && (ballPositionY < secondPlayerPosition + secondPlayerPadSize))
            {
                ballDirectionRight = false;
            }
        }

        if (ballDirectionUp)
        {
            ballPositionY--;
        }
        else
        {
            ballPositionY++;
        }

        if (ballDirectionRight)
        {
            ballPositionX++;
        }
        else
        {
            ballPositionX--;
        }
    }

    /** Draw all ****************************************************************************************************************************************/

    static void DrawFirstPlayer()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        for (int y = firstPlayerPosition; y < (firstPlayerPosition + firstPlayerPadSize); y++)
        {
            PrintAtPosition(0, y, '1');
            PrintAtPosition(1, y, 'P');
        }
    }

    static void DrawSecondPlayer()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        for (int y = secondPlayerPosition; y < (secondPlayerPosition + secondPlayerPadSize); y++)
        {
            PrintAtPosition(Console.WindowWidth - 1, y, '2');
            PrintAtPosition(Console.WindowWidth - 2, y, 'P');
        }

    }

    static void DrawBall()
    {
        PrintAtPosition(ballPositionX, ballPositionY, '@');
    }

    static void PrintResult()
    {
        Console.SetCursorPosition(((Console.WindowWidth / 2) - 2), 0);
        Console.WriteLine("{0} - {1}", firstPlayerPoint, secondPlayerPoint);
    }

    /** MAIN METHOD *************************************************************************************************************************************/

    static void Main()
    {
        RemoveScrollBars();                 // buffer size = window size
        SetInitialPosition();
        SetBallAtTheMiddleOfGameField();
        Console.WriteLine("Press any kay to start...");
        Console.ReadKey();
        while (true)
        {
            /********** Move all ********************************************************************************************************************************/

            //Move first player

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    MoveFirstPlayerUp();
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    MoveFirstPlayerDown();
                }
            }

            //Move second player

            SecondPlayerAIMove();

            //Move ball

            MoveBall();

            /********** Redraw all ******************************************************************************************************************************/

            Console.Clear();                // - clear all
            DrawFirstPlayer();
            DrawSecondPlayer();
            DrawBall();
            PrintResult();                  // - print result
            Thread.Sleep(100);
        }
    }
}




/* 
________________________________________________________
  
 
*                                 *
*               *                 *
*                                 *
*                                 *
*                                 *
*                                 *
*                                 *
 
  
________________________________________________________ 
 
 */


