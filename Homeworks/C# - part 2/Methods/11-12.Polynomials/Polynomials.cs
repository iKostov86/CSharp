using System;
using System.Collections.Generic;

class Polynomials
{
    static void Main()
    {
        int[] polinomialA = new int[] { 1, 0, 5 };
        int[] polinomialB = new int[] { 7, 6, 0 , 8, 9 };
        AddsPolynomials(polinomialA, polinomialB);
        //SubstractPolynomials(polinomialA, polinomialB);
        //MultipliesPolynomials(polinomialA, polinomialB);
    }

    static void AddsPolynomials(int[] polynomialA, int[] polynomialB)
    {
        bool length = polynomialA.Length > polynomialB.Length ? true : false;
        if (length == true)
        {
            for (int i = 0; i < polynomialB.Length; i++)
            {
                polynomialA[i] += polynomialB[i];
            }
            PrintPolynomial(polynomialA);
        }
        else
        {
            for (int i = 0; i < polynomialA.Length; i++)
            {
                polynomialB[i] += polynomialA[i];
            }
            PrintPolynomial(polynomialB);
        }
    }

    static void SubstractPolynomials(int[] polynomialA, int[] polynomialB)
    {
        bool length = polynomialA.Length > polynomialB.Length ? true : false;
        if (length == true)
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

    static void MultipliesPolynomials(int[] polynomialA, int[] polynomialB)
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

    static void PrintPolynomial(int[] polynomial)
    {
        Console.WriteLine();
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            char sign = new char();
            if (i != 0)
            {
                if (Math.Sign(polynomial[i]) == 1)
                {
                    sign = '+';
                }
                else
                {
                    sign = '-';
                }
                Console.Write("{0}x^{1} {2}  ", polynomial[i], i, sign);
            }
            else
            {
                Console.WriteLine(polynomial[i]);
            }
        }
        Console.WriteLine();
    }
}
