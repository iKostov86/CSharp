using System;
using System.Text;

class TranslateNumberInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        byte[] number = new byte[3];
        
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = byte.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        switch (number[0])
        {
            case 1:
                Console.Write("Сто");
                break;
            case 2:
                Console.Write("Двеста");
                break;
            case 3:
                Console.Write("Триста");
                break;
            case 4:
                Console.Write("Четиристотин");
                break;
            case 5:
                Console.Write("Петстотин");
                break;
            case 6:
                Console.Write("Шестстотин");
                break;
            case 7:
                Console.Write("Седемстотин");
                break;
            case 8:
                Console.Write("Осемстотин");
                break;
            case 9:
                Console.Write("Деветстотин");
                break;
            case 0:
            default:
                break;
        }

        if (number[1] != 0 || number[2] != 0)
        {
            if (number[1] == 1)
	        {
                if (number[0] != 0)
                {
                    Console.Write(" и ");
                }
                switch (number[2])
                {
                    case 0:
                        Console.Write("десет");
                        break;
                    case 1:
                        Console.Write("единадесет");
                        break;
                    case 2:
                        Console.Write("дванадесет");
                        break;
                    case 3:
                        Console.Write("тринадесет");
                        break;
                    case 4:
                        Console.Write("четиринадесет");
                        break;
                    case 5:
                        Console.Write("петнадесет");
                        break;
                    case 6:
                        Console.Write("шестнадесет");
                        break;
                    case 7:
                        Console.Write("седемнадесет");
                        break;
                    case 8:
                        Console.Write("осемнадесет");
                        break;
                    case 9:
                        Console.Write("деветнадесет");
                        break;
                    default:
                        break;
                }

	        }

            else if(number[1] != 0)
            {
                if (number[0] != 0 && number[2] == 0)
                {
                    Console.Write(" и ");
                }
                else
                {
                    Console.Write(" ");
                }
                switch (number[1])
                {
                    case 2:
                        Console.Write("двадесет");
                        break;
                    case 3:
                        Console.Write("тридесет");
                        break;
                    case 4:
                        Console.Write("четиридесет");
                        break;
                    case 5:
                        Console.Write("петдесет");
                        break;
                    case 6:
                        Console.Write("шестдесет");
                        break;
                    case 7:
                        Console.Write("седемдесет");
                        break;
                    case 8:
                        Console.Write("осемдесет");
                        break;
                    case 9:
                        Console.Write("деветдесет");
                        break;
                    case 0:
                    default:
                        break;
                }
            }

            if (number[1] != 1 && number[2] != 0)
            {
                if (number[0] != 0 || number[1] != 0)
                {
                    Console.Write(" и ");
                }
                switch (number[2])
                {
                    case 1:
                        Console.Write("едно");
                        break;
                    case 2:
                        Console.Write("две");
                        break;
                    case 3:
                        Console.Write("три");
                        break;
                    case 4:
                        Console.Write("четири");
                        break;
                    case 5:
                        Console.Write("пет");
                        break;
                    case 6:
                        Console.Write("шест");
                        break;
                    case 7:
                        Console.Write("седем");
                        break;
                    case 8:
                        Console.Write("осем");
                        break;
                    case 9:
                        Console.Write("девет");
                        break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine();
    }
}
