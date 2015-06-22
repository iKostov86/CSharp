using System;
using System.Text;

public class DecodeAndDecrypt
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
        StringBuilder sb = new StringBuilder(encryptedMsg);

        int longest;

        if(encryptedMsg.Length > cypherLength)
        {
            longest = encryptedMsg.Length;
        }
        else
        {
            longest = cypherLength;
        }

        for (int i = 0; i < longest; i++)
        {
            sb[i % encryptedMsg.Length] = (char)(((sb[i % encryptedMsg.Length] - 'A') ^ (cypher[i % cypherLength] - 'A')) + 'A');
        }

        return sb.ToString();
    }

    public static string Decode(string encodedMsg)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;

        for (int i = 0; i < encodedMsg.Length; i++)
        {
            if (char.IsDigit(encodedMsg[i]))
            {
                count = (count * 10) + int.Parse(encodedMsg[i].ToString());
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
