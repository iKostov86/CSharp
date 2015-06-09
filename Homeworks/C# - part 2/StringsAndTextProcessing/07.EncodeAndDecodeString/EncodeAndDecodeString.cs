using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeAndDecodeString
{
    static void Main()
    {
        char[] input = "bira i more".ToArray();
        char[] keyCipher = "123".ToArray();

        char[] output = EncodingDecodingFunc(input, keyCipher);
        Console.WriteLine(output);

        output = EncodingDecodingFunc(output, keyCipher);
        Console.WriteLine(output);
    }

    static char[] EncodingDecodingFunc(char[] input, char[] keyCipher)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] ^= keyCipher[i % keyCipher.Length];
        }

        return input;
    }
}

