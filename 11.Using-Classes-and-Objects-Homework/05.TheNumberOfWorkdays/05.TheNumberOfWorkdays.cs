//Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class TheNumberOfWorkdays
{
    static int i;
    static int TheNumbersOfDays(int a,int b,int c,int difference)
    {
        DateTime today = new DateTime(a,b,c);
        int answer = difference;
        DateTime[] holidays = new DateTime[10];
        for ( i = 1; i <=difference; i++)
        {
           holidays[0] = new DateTime(today.Year, 3, 3);
           holidays[1] = new DateTime(today.Year, 5, 1);
           holidays[2] = new DateTime(today.Year, 5, 6);
           holidays[3] = new DateTime(today.Year, 5, 24);
           holidays[4] = new DateTime(today.Year, 9, 6);
           holidays[5] = new DateTime(today.Year, 9, 22);
           holidays[6] = new DateTime(today.Year, 11, 1);
           holidays[7] = new DateTime(today.Year, 12, 24);
           holidays[8] = new DateTime(today.Year, 12, 26);
           holidays[9] = new DateTime(today.Year, 12, 25);
           foreach (var n in holidays)
           {
               if (today.Date == n.Date || today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
               {
                   answer--;
                   break;
               }
           }
            today = today.AddDays(1);
        }
        return answer;
    }
    static void Main()
    {
        int beginingYear = int.Parse(Console.ReadLine());
        int beginingMonth = int.Parse(Console.ReadLine());
        int beginingDay = int.Parse(Console.ReadLine());
        DateTime today = new DateTime(beginingYear, beginingMonth, beginingDay);

        int endYear = int.Parse(Console.ReadLine());
        int endMonth = int.Parse(Console.ReadLine());
        int endDay=int.Parse(Console.ReadLine());
        DateTime givenDay = new DateTime(endYear, endMonth, endDay);
        int diference = 0;
        diference+=-(int)(today-givenDay).TotalDays;

        Console.WriteLine(TheNumbersOfDays(beginingYear,beginingMonth,beginingDay,diference));
    }
}