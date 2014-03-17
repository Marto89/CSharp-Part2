//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseNumber
{
    static string ReverseDecimalNumber(int number)
    {
        string realNumber = string.Empty;
        while (number>0)
        {          
            realNumber += number%10;
            number /= 10;
        }
        return realNumber;
    }
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        if(inputNumber<0)
        {
            inputNumber = -inputNumber;
            Console.WriteLine("-{0}",int.Parse(ReverseDecimalNumber(inputNumber)));
        }
        else if(inputNumber>0)
        {
            Console.WriteLine(int.Parse(ReverseDecimalNumber(inputNumber)));
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}