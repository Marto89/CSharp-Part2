//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Linq;

class BinaryToDecimalProgram
{
    static void Main()
    {
        string input =Console.ReadLine();

        int result = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result += (input[i]-48)*(int)(Math.Pow(2,input.Length-1-i));
        }
        Console.WriteLine(result);
    }
}