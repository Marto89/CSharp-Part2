﻿//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

using System;

class Filled20CharactersString
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }
        else
        {
            input = input.Substring(0,20);
        }
        Console.WriteLine(input);
    }
}