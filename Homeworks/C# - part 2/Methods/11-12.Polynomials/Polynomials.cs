using System;

public class Polynomials
{
    internal static void Main()
    {
        string firstPolinomialAsStr = "x + 5x3";
        string secondPolinomialAsStr = "7x + 6x2 + 8x4 + 9x5";
        string[] firstPolinomialMembers =
            firstPolinomialAsStr
            .Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondPolinomialMembers =
            secondPolinomialAsStr
            .Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);


        AddsPolynomials(polinomialA, polinomialB);
        //SubstractPolynomials(polinomialA, polinomialB);
        //MultipliesPolynomials(polinomialA, polinomialB);
    }

    public static void AddsPolynomials(int[] polynomialA, int[] polynomialB)
    {
        int len = Math.Max(polynomialA.Length, polynomialB.Length);

        for (int i = 0; i < len; i++)
        {
            polynomialA[i] += polynomialB[i];
        }

        PrintPolynomial(polynomialA);
    }

    public static void SubstractPolynomials(int[] polynomialA, int[] polynomialB)
    {
        bool length = polynomialA.Length > polynomialB.Length ? true : false;

        if (length)
        {
            for (int i = 0; i < polynomialB.Length; i++)
            {
                polynomialA[i] -= polynomialB[i];
            }

            PrintPolynomial(polynomialA);
        }
        else
        {
            for (int i = 0; i < polynomialA.Length; i++)
            {
                polynomialB[i] -= polynomialA[i];
            }

            PrintPolynomial(polynomialB);
        }
    }

    public static void MultipliesPolynomials(int[] polynomialA, int[] polynomialB)
    {
        int length = polynomialA.Length + polynomialB.Length;
        int[] polynomial = new int[length - 1];

        for (int i = 0; i < polynomialA.Length; i++)
        {
            for (int j = 0; j < polynomialB.Length; j++)
            {
                polynomial[i + j] += (polynomialA[i] * polynomialB[j]);
            }
        }

        PrintPolynomial(polynomial);
    }

    public static void PrintPolynomial(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            char positiveSign = '+';
            char negativeSign = '-';
            char sign = new char();

            if (i != 0)
            {
                if (Math.Sign(polynomial[i]) == 1)
                {
                    sign = positiveSign;
                }
                else
                {
                    sign = negativeSign;
                }

                Console.Write("{0}x^{1} {2}  ", polynomial[i], i, sign);
            }
            else
            {
                Console.WriteLine(polynomial[i]);
            }
        }
    }
}