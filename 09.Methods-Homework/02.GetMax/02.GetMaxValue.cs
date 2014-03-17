//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxValue
{
   private static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        return secondNumber;
    }
    static void Main()
    {
        Console.Write("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(a,b),c));
    }
}
