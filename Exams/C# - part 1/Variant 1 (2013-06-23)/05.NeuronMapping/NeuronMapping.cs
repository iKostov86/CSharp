using System;
using System.Collections.Generic;

class NeuronMapping
{
    static void Main()
    {
        var input = new List<long>();
        long currentLine = 0;

        while (long.TryParse(Console.ReadLine(), out currentLine) && currentLine != -1)
        {
            input.Add(currentLine);
        }

        var output = new long[input.Count];

        for (int n = 0; n < input.Count; n++)
        {
            bool inNeuron = false;
            int mostRightIndex = -1;
            int mostLeftIndex = -1;
            output[n] = 0;

            for (int p = 0; p < 32; p++)
            {
                long mask = 1 << p;
                long bit = (input[n] & mask) >> p;

                if (!inNeuron)
                {
                    if (bit == 1)
                    {
                        inNeuron = true;
                    }
                }
                else //inNeuron
                {
                    if (bit == 0)
                    {
                        if (mostRightIndex == -1)
                        {
                            mostRightIndex = p;
                        }
                    }
                    else //bit == 1
                    {
                        if (mostRightIndex != -1)
                        {
                            mostLeftIndex = p;
                            break;
                        }
                    }
                }
            }

            if (mostLeftIndex != -1 && mostRightIndex != -1)
            {
                for (int p = mostRightIndex; p < mostLeftIndex; p++)
                {
                    long mask = 1u << p;
                    long bit = (input[n] & mask) >> p;

                    if (bit == 0)
                    {
                        output[n] = output[n] | mask;
                    }
                }
            }
        }

        Console.WriteLine(String.Join("\n", output));
    }
}

