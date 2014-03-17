//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ExtractDates
{
    class DatesExtractor
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern =
                "\\b(?<day>[\\d]{1,2})\\.(?<month>[\\d]{2})\\.(?<year>[\\d]{4})\\.";
            Regex dates = new Regex(pattern);

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match date in matches)
            {
                DateTime theDate = new DateTime(int.Parse(date.Groups["year"].ToString()),
                    int.Parse(date.Groups["month"].ToString()),
                    int.Parse(date.Groups["day"].ToString()));
                CultureInfo culture = new CultureInfo("en-CA");
                Console.WriteLine(theDate.ToString("d", culture));
            }
        }
    }
}
