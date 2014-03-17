//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class FormatOutputNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        Console.Write("{0,15:D}\n" +
                      "{0,15:X}\n" +
                      "{1,15:P3}\n" + 
                      "{1,15:E}\n",
                    (int)number,number);
    }
}