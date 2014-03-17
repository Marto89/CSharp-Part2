using System;

class LastDigitInWord
{
    static string LastDigit(int number)
    {
        if (number < 0)
        {
            number = -number;
        }
        number = number % 10;
        switch (number)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
        }
        return "Zero";
    }
    static void Main()
    {
        Console.Write("Enter your number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(inputNumber));
    }
}
