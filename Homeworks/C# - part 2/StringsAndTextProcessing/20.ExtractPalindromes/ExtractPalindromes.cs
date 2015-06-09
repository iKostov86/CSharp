using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractPalindromes
{
    static void Main()
    {
        string input = "ebasi mamata, ABBA ep lamal i e nqkakvo exe!";
        var extraxtWords = input.Split(new[] { ' ', ',', ':', ';', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Where(x => x.Length > 2);

        foreach (var word in extraxtWords)
        {
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome == true)
            {
                Console.WriteLine(word);
            }
        }
        Console.WriteLine();
    }
}
