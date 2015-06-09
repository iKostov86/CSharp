using System;

/****** Wneh we use switch statement ************************************************/

enum daysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class MyExercise
{
    enum examples {нула = 0, едно, две, три, четири, пет }

    static void Main()
    {
        //daysOfWeek dayOfWeek = daysOfWeek.Friday;

        //switch (dayOfWeek)
        //{
        //    case daysOfWeek.Monday:
        //        break;
        //    case daysOfWeek.Tuesday:
        //        break;
        //    case daysOfWeek.Wednesday:
        //        break;
        //    case daysOfWeek.Thursday:
        //        break;
        //    case daysOfWeek.Friday:
        //        break;
        //    case daysOfWeek.Saturday:
        //        break;
        //    case daysOfWeek.Sunday:
        //        break;
        //    default:
        //        break;
        //}

        examples justExample = (examples)byte.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(justExample);
        Console.WriteLine();
    }
}

