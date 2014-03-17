//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

class SignedShortToBinary
{
     static string ShortToBinary(short number)
    {
        string binaryRepresentation = string.Empty;
        while (number > 0)
        {
            binaryRepresentation += (number % 2).ToString();
            number /= 2;
        }
        while (binaryRepresentation.Length < 16)
        {
            binaryRepresentation += 0;
        }
        return binaryRepresentation;
    }
     static void PrintPositiveNumber(string binaryRepresentation)
    {
        for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryRepresentation[i]);
            if (i == binaryRepresentation.Length / 2)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
     static void PrintNegativeNumber(string binaryRepresentation)
     {
         for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
         {
             if (binaryRepresentation[i] == '0')
             {
                 Console.Write(1);
                 if(i==binaryRepresentation.Length/2)
                 {
                     Console.Write(" ");
                 }
             }
             else if(binaryRepresentation[i]=='1')
             {
                 Console.Write(0); 
                 if (i == binaryRepresentation.Length/2)
                 {
                     Console.Write(" ");
                 }
             }
         }
         Console.WriteLine();
     }
     static void Main()
     {
         short number = short.Parse(Console.ReadLine());
         string finalResult = string.Empty;
         if (number < 0)
         {
             number = (short)(~number);
             finalResult = ShortToBinary(number);
             PrintNegativeNumber(finalResult);
         }
         else
         {
             finalResult = ShortToBinary(number);
             PrintPositiveNumber(finalResult);
         }
     }
}