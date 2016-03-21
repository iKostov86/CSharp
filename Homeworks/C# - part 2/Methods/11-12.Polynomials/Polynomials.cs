using System;

public class Polynomials
{
    internal static void Main()
    {
        string firstPolinomialAsStr = "-5 + x + 5x3";
        string secondPolinomialAsStr = "7x + 6x2 + 8x4 + 9x5";
        string[] firstPolinomialMembers =
            firstPolinomialAsStr
            .Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondPolinomialMembers =
            secondPolinomialAsStr
            .Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);
        int[] firstPolinomialCoefficients = ConvertPolinomialMembersToArrayOfTheirCoefficients(firstPolinomialMembers);
        int[] secondPolinomialCoefficients = ConvertPolinomialMembersToArrayOfTheirCoefficients(secondPolinomialMembers);

        //AddsPolynomials(firstPolinomialCoefficients, secondPolinomialCoefficients);
        SubstractPolynomials(firstPolinomialCoefficients, secondPolinomialCoefficients);
        //MultipliesPolynomials(firstPolinomialCoefficients, secondPolinomialCoefficients);
    }

    public static void AddsPolynomials(int[] firstPolinomial, int[] secondPolinomial)
    {
        int firstPolinomialLen = firstPolinomial.Length;
        int secondPolinomialLen = secondPolinomial.Length;

        if (firstPolinomialLen > secondPolinomialLen)
        {
            for (int i = 0; i < secondPolinomialLen; i++)
            {
                firstPolinomial[i] += secondPolinomial[i];
            }

            PrintPolynomial(firstPolinomial);
        }
        else
        {
            for (int i = 0; i < firstPolinomialLen; i++)
            {
                secondPolinomial[i] += firstPolinomial[i];
            }

            PrintPolynomial(secondPolinomial);
        }

    }

    public static void SubstractPolynomials(int[] firstPolinomial, int[] secondPolinomial)
    {
        for (int i = 0, len = secondPolinomial.Length; i < len; i++)
        {
            secondPolinomial[i] *= -1;
        }

        AddsPolynomials(firstPolinomial, secondPolinomial);
    }

    public static void MultipliesPolynomials(int[] firstPolinomial, int[] secondPolinomial)
    {
        int len = firstPolinomial.Length + secondPolinomial.Length;
        int[] polynomial = new int[len - 1];

        for (int i = 0, firstPolinomialLen = firstPolinomial.Length; i < firstPolinomialLen; i++)
        {
            for (int j = 0, secondPolinomialLen = secondPolinomial.Length; j < secondPolinomialLen; j++)
            {
                polynomial[i + j] += (firstPolinomial[i] * secondPolinomial[j]);
            }
        }

        PrintPolynomial(polynomial);
    }

    public static int[] ConvertPolinomialMembersToArrayOfTheirCoefficients(string[] polinomialMembers)
    {
        var polinomialMembersCount = polinomialMembers.Length;
        var polinomialCoefficients = new int[polinomialMembersCount];
        var container = new int[polinomialMembersCount];

        for (int i = 0; i < polinomialMembersCount; i++)
        {
            string polinomialMember = polinomialMembers[i];
            int polinomialMemberLen = polinomialMember.Length;
            string valueAsStr = string.Empty;
            string indexAsStr = string.Empty;
            bool isValueSet = false;
            bool hasIndex = false;
            int value = new int();
            int index = new int();

            for (int j = 0; j < polinomialMemberLen; j++)
            {
                char polinomialMemberSymbol = polinomialMember[j];

                if (polinomialMemberSymbol == '-')
                {
                    valueAsStr += '-';
                }
                else if (polinomialMemberSymbol != 'x')
                {
                    if (isValueSet)
                    {
                        indexAsStr += polinomialMemberSymbol;
                    }
                    else
                    {
                        valueAsStr += polinomialMemberSymbol;
                    }
                }
                else
                {
                    isValueSet = true;
                    hasIndex = true;
                    value = int.Parse(valueAsStr != string.Empty ? valueAsStr : "1");
                }
            }

            if (!isValueSet)
            {
                value = int.Parse(valueAsStr);
            }

            if (hasIndex)
            {
                index = int.Parse(indexAsStr != string.Empty ? indexAsStr : "1");
            }
            else
            {
                index = 0;
            }

            if (polinomialCoefficients.Length <= index)
            {
                Array.Copy(polinomialCoefficients, container, polinomialCoefficients.Length);
                polinomialCoefficients = new int[index + 1];
                Array.Copy(container, polinomialCoefficients, container.Length);
                container = new int[polinomialCoefficients.Length];
            }

            polinomialCoefficients[index] = value;
        }

        return polinomialCoefficients;
    }

    public static void PrintPolynomial(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i > 0; i--)
        {
            char sign = new char();

            // Math.Sign(polynomial[i])
            if (polynomial[i] < 0)
            {
                sign = '-';
                polynomial[i] *= -1;
            }
            else
            {
                sign = '+';
            }

            Console.Write("{0}x^{1} {2} ", polynomial[i], i, sign);
        }

        Console.WriteLine(polynomial[0]);
    }
}