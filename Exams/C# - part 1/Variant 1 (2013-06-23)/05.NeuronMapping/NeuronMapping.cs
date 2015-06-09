using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NeuronMapping
{
    static void Main()
    {
        uint[] input = new uint[] { 480, 272, 224, 16252928, 50593792, 33685504, 67239936, 67174400, 33587200, 16809984, 16973824, 8650752, 7864320, 0 };
        uint[] output = new uint[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            byte[] inputBits = new byte[32];
            int j = 0;

            //convert int to binary
            while (input[i] > 0)
	        {
                if ((input[i] & 1) == 1)
                {
                    inputBits[j] = 1;
                }
                else
                {
                    inputBits[j] = 0;
                }
                j++;
                input[i] >>= 1;
	        }

            Array.Reverse(inputBits);

            for (int m = 0; m < inputBits.Length; m++)
            {
                if (inputBits[m] == 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('1');
                }
            }

            Console.Write(" ");

            bool inImage = false;
            byte[] outputBits = new byte[32];

            int start = 0;
            int end = 0;

            //get start
            for (int s = 0; s < inputBits.Length; s++)
            {
                if (inputBits[s] == 1)
                {
                    start = s;
                    break;
                }
            }
            //get end
            for (int e = inputBits.Length - 1; e > -1; e--)
            {
                if (inputBits[e] == 1)
                {
                    end = e;
                    break;
                }
            }


            for (int k = start; k < end; k++)
            {
                if (inputBits[k] == 1)
                {
                    outputBits[k] = 0;
                }
                else
                {
                    outputBits[k] = 1;
                }
            }

            for (int n = 0; n < outputBits.Length; n++)
            {
                if (outputBits[n] == 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('1');
                }
            }
            Console.WriteLine();

            //convert binary to int
            Array.Reverse(outputBits);
            uint outputTemp = 0;

            for (int r = 0; r < 32; r++)
            {
                outputTemp += outputBits[r] * (uint)Math.Pow(2.0, (double)r);
            }
            output[i] = outputTemp;
        }

        //Console.WriteLine(input.Length);
        //Console.WriteLine(output.Length);
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}
