using System;
using System.Linq;

public class ExtractPalindromes
{
    internal static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = "What is this, ABBA is LAMAL and there is EXE!";

        // v.1
        var extraxtedWords = input
            .Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length > 2);

        foreach (var word in extraxtedWords)
        {
            bool isPalindrome = true;

            for (int i = 0, len = word.Length / 2; i < len; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(word);
            }
        }
    }
}
