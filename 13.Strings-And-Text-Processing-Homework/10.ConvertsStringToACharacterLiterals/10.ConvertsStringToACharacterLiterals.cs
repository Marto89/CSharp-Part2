//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;

class ConvertsStringToACharacterLiterals
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(@"\u{0:x4}",(int)input[i]);
        }
        Console.WriteLine();    
    }
}