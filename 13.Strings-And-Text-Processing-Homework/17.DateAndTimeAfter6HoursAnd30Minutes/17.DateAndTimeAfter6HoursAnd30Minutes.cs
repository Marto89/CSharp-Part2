//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
class DateAndTimeAfter6HoursAnd30Minutes
{
    static void Main()
    {
        string format = "d.M.yyyy H:mm:ss";
        DateTime now = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        DateTime after=now.AddHours(6.5);
        Console.WriteLine("{0:d.M.yyyy HH:mm:ss}",after);
    }
}