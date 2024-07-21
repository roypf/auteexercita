using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog";
        string pattern = @"\b\w{5}\b"; // Match words that are exactly 5 characters long

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
