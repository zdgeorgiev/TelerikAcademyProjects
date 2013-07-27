using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDate
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";

        MatchCollection dates = Regex.Matches(input, pattern);

        foreach (var date in dates)
        {
            DateTime currentDate = DateTime.Parse(date.ToString());
            Console.WriteLine(currentDate.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}