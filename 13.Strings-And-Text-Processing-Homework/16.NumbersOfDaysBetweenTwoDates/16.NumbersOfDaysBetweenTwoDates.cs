//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

using System;
using System.Globalization;
class NumbersOfDaysBetweenTwoDates
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        Console.WriteLine(Math.Abs((secondDate-firstDate).TotalDays));
    }
}