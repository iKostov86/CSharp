using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecodeAndDecrypt
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();

        int cypherLength = GetCypherLengt(input);

        string encodedMsg = input.Substring(0, input.Length - cypherLength.ToString().Length);
        string encryptedMsg = Decode(encodedMsg);
        string cypher = GetCypher(encryptedMsg, cypherLength);
        string message = Decrypt(encryptedMsg.Substring(0, encryptedMsg.Length - cypherLength), cypher, cypherLength);

        Console.WriteLine(message);
    }

    public static int GetCypherLengt(string input)
    {
        int index = input.Length - 1;

        while (char.IsDigit(input[index]))
        {
            index--;
        }

        return int.Parse(input.Substring(index + 1, input.Length - index - 1));
    }

    public static string GetCypher(string encryptedMsg, int cypherLength)
    {
        return encryptedMsg.Substring(encryptedMsg.Length - cypherLength, cypherLength);
    }

    public static string Decrypt(string encryptedMsg, string cypher, int cypherLength)
    {
        StringBuilder sb = new StringBuilder();

        // Aligning encrypted message and cypher length
        if (encryptedMsg.Length > cypherLength)
        {
            sb.Append(cypher);

            for (int i = cypherLength, j = 0; i < encryptedMsg.Length; i++, j++)
            {
                if (j == cypherLength - 1)
                {
                    j = 0;
                }

                sb.Append(cypher[j]);
            }

            cypher = sb.ToString();
        }
        else if (encryptedMsg.Length < cypherLength)
        {
            sb.Append(encryptedMsg);

            for (int i = encryptedMsg.Length, j = 0; i < cypherLength; i++, j++)
            {
                if (j == encryptedMsg.Length)
                {
                    j = 0;
                }

                sb.Append(encryptedMsg[j]);
            }

            encryptedMsg = sb.ToString();
        }

        sb.Clear();

        // Decode message

        for (int i = 0; i < cypherLength; i++)
        {
            var result1 = encryptedMsg[i] ^ cypher[i];
            var result = (char)result1;
            sb.Append(result);
        }



        return sb.ToString() + 65;
    }

    public static string Decode(string encodedMsg)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;

        for (int i = 0; i < encodedMsg.Length; i++)
        {
            if (char.IsDigit(encodedMsg[i]))
            {
                count = count * 10 + int.Parse(encodedMsg[i].ToString());
            }
            else if (count == 0)
            {
                sb.Append(encodedMsg[i]);
            }
            else
            {
                for (int j = 0; j < count; j++)
                {
                    sb.Append(encodedMsg[i]);
                }

                count = 0;
            }
        }

        return sb.ToString();
    }
}
