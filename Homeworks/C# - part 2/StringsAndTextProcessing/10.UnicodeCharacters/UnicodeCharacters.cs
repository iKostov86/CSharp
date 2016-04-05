using System;
using System.Linq;
using System.Text;

public class UnicodeCharacters
{
    internal static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = "Hi!";

        // v.1
        StringBuilder sb = new StringBuilder();

        foreach (char ch in input)
        {
            sb.AppendFormat("{0}{1:x4}", "\\u", (int)ch);
        }

        Console.WriteLine(sb);

        // v.2
        string output = input.Aggregate(string.Empty, (current, ch) => current + string.Format(@"\u{0:X4}", (int)ch));

        Console.WriteLine(output);

        Console.WriteLine("\\u0048\\u0069\\u0021");
    }
}
