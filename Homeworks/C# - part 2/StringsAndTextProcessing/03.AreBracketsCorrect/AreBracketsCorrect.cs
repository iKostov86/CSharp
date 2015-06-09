using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class AreBracketsCorrect
{
    static void Main()
    {
        string expression = "())(()";//"((a+b)/5-d)(";

        //v.1

        int bracketsCount = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == ')')
            {
                bracketsCount--;
                if (bracketsCount < 0)
                {
                    break;
                }
            }
            else if (expression[i] == '(')
            {
                bracketsCount++;
            }
        }

        if (bracketsCount != 0)
        {
            Console.WriteLine("Incorrect expression!");
        }
        else
        {
            Console.WriteLine("Correct expression!");
        }

        //v.2

        //Stack<char> myStack = new Stack<char>();
        //myStack.Push('.');

        //for (int i = 0; i < expression.Length; i++)
        //{
        //    if (expression[i] == ')')
        //    {
        //        myStack.Pop();
        //        if (myStack.Count < 1)
        //        {
        //            break;
        //        }
        //    }
        //    else if (expression[i] == '(')
        //    {
        //        myStack.Push('.');
        //    }
        //}

        //if (myStack.Count != 1)
        //{
        //    Console.WriteLine("Incorrect expression!");
        //}
        //else
        //{
        //    Console.WriteLine("Correct expression!");
        //}
    }
}