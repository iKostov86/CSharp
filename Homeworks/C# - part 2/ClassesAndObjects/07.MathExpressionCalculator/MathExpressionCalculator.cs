using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class MathExpressionCalculator
{
    public static List<char> arithmeticOperation = new List<char>() { '+', '-', '*', '/' };
    public static List<char> brackets = new List<char>() { '(', ')' };
    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

    public static string TrimInput(string input)
    {
        string trimmedInput = input.Replace(" ", string.Empty);
        return trimmedInput;
    }

    public static void PutInvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }

    public static int Precedence(string arithmeticOperator)
    {
        if (arithmeticOperator == "+" || arithmeticOperator == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public static List<string> SeparateTokens(string input)
    {
        List<string> signs = new List<string>();

        StringBuilder number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '(' || arithmeticOperation.Contains(input[i - 1])))
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
            {
                signs.Add(number.ToString());
                number.Clear();
                i--;
            }
            else if (brackets.Contains(input[i]))
            {
                signs.Add(input[i].ToString());
            }
            else if (arithmeticOperation.Contains(input[i]))
            {
                signs.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                signs.Add(",");
            }
            else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
            {
                signs.Add("ln");
                i++;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
            {
                signs.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
            {
                signs.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }

        }

        if (number.Length != 0)
        {
            signs.Add(number.ToString());
        }

        return signs;
    }

    public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        
        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double number;

            if (double.TryParse(currentToken, out number))
            {
                queue.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ",")
            {
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid brackets or function separator!");
                }
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (arithmeticOperation.Contains(currentToken[0]))
            {
                while (stack.Count != 0 && arithmeticOperation.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (currentToken == "(")
            {
                stack.Push("(");
            }
            else if (currentToken == ")")
            {
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid brackets or function separator!");
                }
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();

                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid brackets or function separator!");
            }
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    //TO DO: POSTFIX ALGORITHM
    public static double GetResultFromRPN(Queue<string> queue)
    {
        return 0;
    }

    static void Main()
    {
        PutInvariantCulture();

        string input = Console.ReadLine().Trim();
        string trimmedInput = TrimInput(input);

        var separateTokens = SeparateTokens(trimmedInput);
        var reversePolishNotation = ConvertToReversePolishNotation(separateTokens);
        var result = PostfixAlgorithm(reversePolishNotation);
    }
}