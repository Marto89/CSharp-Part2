//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        int  input = int.Parse(Console.ReadLine());

        string binaryRepresentation=string.Empty;
        do
        {
            binaryRepresentation += (input % 2).ToString();
            input /= 2;
        } while (input > 0);
        for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
        {
            Console.Write(binaryRepresentation[i]);
        }
        Console.WriteLine();
    }
}