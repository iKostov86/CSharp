using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidNumber
{
    static void Main()
    {
        double number = new double();
        try
        {
            number = double.Parse(Console.ReadLine());
            double sqrtNum = SqrtMethod(number);
            Console.WriteLine(sqrtNum);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }

    public static double SqrtMethod(double value)
    {
        if (value < 0)
        {
            throw new OverflowException();
        }
        return Math.Sqrt(value);
    }
}
