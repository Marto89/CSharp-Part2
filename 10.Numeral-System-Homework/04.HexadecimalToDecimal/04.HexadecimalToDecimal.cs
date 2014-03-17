//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        int result=0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if((input[i]-48)<10)
            {
                result += (input[i]-48) * (int)Math.Pow(16, input.Length - 1 - i);
            }
            else 
            {
               switch (input[i])
               {
                   case'A':
                       result += 10 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
                   case 'B':
                       result += 11 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
                   case 'C':
                       result += 12 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
                   case 'D':
                       result += 13 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
                   case 'E':
                       result += 14 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
                   case 'F':
                       result += 15 * (int)Math.Pow(16, input.Length - 1 - i);
                       break;
               }              
            }
        }
        Console.WriteLine(result);
    }
}