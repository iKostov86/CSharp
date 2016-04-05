using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EncodeAndDecodeString
{
    internal static void Main()
    {
        char[] input = "bira i more".ToArray();
        char[] keyCipher = "123".ToArray();

        char[] output = EncodingDecodingFunc(input, keyCipher);
        Console.WriteLine(output);

        output = EncodingDecodingFunc(output, keyCipher);
        Console.WriteLine(output);
    }

    public static char[] EncodingDecodingFunc(char[] input, char[] keyCipher)
    {
        int keyCipherLen = keyCipher.Length;
        for (int i = 0, len = input.Length; i < len; i++)
        {
            input[i] ^= keyCipher[i % keyCipherLen];
        }

        return input;
    }
}