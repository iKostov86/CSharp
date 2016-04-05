using System;

public class SystemString
{
    internal static void Main()
    {
        Console.WriteLine(@"What is String?
 => Strings are sequence of characters
 => Each character is a Unicode symbol
The System.String Class
 => Strings are represented by System.String objects in .NET Framework
    - String objects contain an immutable(read-only) sequence of characters;
    - Strings use Unicode to support multiple languages and alphabets;
 => Strings are stored in the dynamic memory (managed heap)
 => System.String is reference type
 => String objects are like arrays of characters(char[])
    - Have fixed length(Strings.Length)
    - Elements can be accessed directly by index (the index is in the range[0...Length - 1])

Declaring Strings
 => Several ways of declaring string variables:
    - Using the C# keyword string
    - Using the .NET's fully qualified class name System.String
    - The below three declaration are equivalent:
        string str1;
        System.String str2;
        String str3;

Creating Strings
 => Before initializing a string variable has null value
 => Strings can be initialized by:
    - Assigning a string literal to the string variable
    - Assigning the value of another string variable
    - Assigning the result of operation of type string

Reading and Printing Strings
 => Reading strings from the console
    - Use the method Console.ReadLine()
 => Printing strings to the console
    - Use the method Write() and WriteLine()

Comparing Strings
 => Several ways to compare two strings:
    - Dictionary-based string comparison
        + Case-insensitive
            (string.Compare(str1, str2, true))
        + Case-sensitive
            (string.Compare(str1, str2, false))
 => Equality checking by operator ==
    - Performs case-sensitive compare
        if (str1 == str2) {}
 => Using the case-sensitive Equals() method
    - The same effect like the operator ==
        if (str1.Equals(str2)) {}
Concatenating Strings
 => There are two ways to combine strings:
    - Using the Concat() method
        string str = String.Concat(str1, str2);
    - Using the + or the += operators
        string str = str1 + str2 + str3;
        string str += str1;
 => Any object can be appended to a string
        string name = ""Peter""
        int age = 22;
        string s = name + "" "" + age; // -> ""Peter 22""
Searching in Strings
 => Finding a character or substring within given string
    - First occurrence
        IndexOf(string str)
    - First occurrence starting at given position
        IndexOf(string str, int startIndex)
    - Last occurrence
        LastIndex(string)
Extracting Substrings
 => Extracting substrings
    - str.Substring(int startIndex, int length)
        string filename = @""C:\Pics\Rila2009.jpg"";
        string name = filename.Substring(8, 8);
        // name is Rilla2009
    - str.Substring(int startIndex)
        string filename = @""C:\Pics\Summer2009.jpg"";
        string nameAndExtension = filename.Substring(8);
        // nameAndExtension is Summer2009.jpg
Splitting Strings
 => To split a string by given separator(s) use the following method:
        string[] Split(params char[])

Replacing and Deleting Substrings
 => Replace(string, string) = replaces all occurrences of given string with another
    - The result is new string (strings are immutable)
        string cocktail = ""Vodka + Martini + Cherry"";
        string replaced = cocktail.Replace(""+"", ""and"");
        // Vodka and Martini and Cherry
 => Remove(index, length) = deletes part of a string and produces new string as result
        string price = ""$ 1234567"";
        string lowPrice = price.Remove(2, 3);
        // $ 4567

Changing Characker Casing
 => Using method ToLower()
        string alpha = ""aBcDeFg"";
        string lowerAlpha = alpha.ToLower(); // abcdefg
        Console.WriteLine(lowerAlpha);
 => Using method ToUpper()
        string alpha = ""aBcDeFg"";
        string upperAlpha = alpha.ToUpper(); // ABCDEFG
        Console.WriteLine(upperAlpha);

Trimming White Space
 => Using Trim()
        string s = ""   example of white space  "";
        string clean = s.Trim();
        Console.WriteLine(clean);
 => Using Trim(chars)
        string s = "" \t\nHello! \n"";
        string clean = s.Trim(' ', ',', '!', '\n', '\t');
        Console.WriteLine(clean); // Hello
 => Using TrimStart() and TrimEnd()
        string s = ""   C#  "";
        string clean = s.TrimStart().TrimEnd();

Constructing Strings
 => Strings are immutable!
    - Concat(), Replace(), Trim(), ...return new string, do not modify the old one
 => Do not use + for strings in a loop!
    - It runs very , very inefficiently!

StringBuilder: How it Works?
 => StringBuilder keeps a buffer memory, allocated in advance
    - Most operations use the buffer memory and do not allocate new objects

How the + Operator Performs String Concatenations?
 => Consider the following string concatenation:
        string result = str1 + str2;
 => It is equivalent to this code:
        StringBuilder sb = new StringBuilder();
        sb.Append(str1);
        sb.Append(str2);
        string result = sb.ToString();
 => Several new objects are created and left to the garbage collector for deallocation
    - What happens when using + in a loop?

The StringBuilder Class
 => StringBuilder(int capacity) constructor allocates in advance buffer of given size
    - By default 16 charackters are allocated
 => Capacity holds the currently allocated space(in characters)
 => this[int index] (indexer in C#) gices acces to the char value at given position
 => Length holds the length of the strings in the buffer
 => Append(...) appends a string or another object after the last character in the buffer
 => Remove(int startIndex, int length) removes the characters in given range
 => Insert(int index, string str) insert given string (or object) at given position
 => Replace(string oldStr, string newStr) replaces all occurrences of a substring
 => ToString() converts the StringBuilder to String

Changing the Contents of a String with StringBuilder
 => Use the System.Text.StringBuilder class for modfiable strings of characters
 => Use StringBuilder if you need to keep adding characters to a string

Method ToString
 => All classes in CC# have public virtual method ToString()
    - Returns a human-readable, culture-sensitive string representing the object
    - Most .NET Framework types have own implementation of ToString()
        + int, float, bool, DateTime

Method ToString(format)
 => We can apply specific formatting when converting object to string
    - ToString(formatString) methid

Formatting Strings
 => The formatting strings are different for the different types
 => Some formatting strings for numbers:
    - D = number(for integer types)
    - C = currency(according to current culture)
    - E = number in exponential notation
    - P = percentage
    - X = hexadecimal number
    - F = fixed point(for real numbers)

Method Strings.Format()
 => Applies templates for formatting strings
    - Placeholders are used for dynamic text
    - Like Console.WriteLine(...)

Composite Formatting
 => The placeholders in the composite formatting strings are specified as follows:
        {index[, alignment][:formatString]}

Formating Dates
 => Dates have their own formatting strings
    - d, dd = day(with/without leading zero)
    - M, MM = month
    - YY, YYYY = year(2 or 4 digits)
    - h, HH, m, mm, s, ss = hour, minute, second

Cultures
 => Cultures in .NET specify formatting/parsing settings specific to country/region/language
 => Printing the current culture:
        Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);
 => Changing the current culture:
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(""en-CA"");
 => Culture-sensitive ToString():
        CultureInfo culture = new CultureInfo(""fr-CA"");
        string s = number.ToString(""C"", culture); // 42,00 $

Parsing Numbers and Dates
 => Parsing numbers and dates is culture-sensitive
 => Parsing a real number using ""."" as separator:
        string str = ""3.14"";
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float f = float.Parse(str); // f = 3.14
 => Parsing a date in specific format:
        string dateStr = ""25.07.2011"";
        DateTime date = DateTime.ParseExact(dateStr, ""dd.MM.yyyy"", CultureInfo.InvariantCulture);

Summary
 => Strings are immutable sequence of characters(instances of System.String)
    - Declared by the keyword string in C#
    - Can be initialized by string literals
 => Most important string processing members are:
    - Length, this[], Compare(str1, str2),
    IndexOf(str), LastIndexOf(str),
    Substring(startIndex, length),
    Replace(oldStr, newStr),
    Remove(startIndex, length), ToLower(),
    ToUpper(), Trim()
 => Objects can be converted to strings and can be formatted in different styles(using ToString() method)
 => Strings can be constructed by using placeholders and formatting strings(String.Format(...))");
    }
}