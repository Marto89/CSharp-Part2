//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class ListInAnAlphabeticalOrder
{
    static void Main()
    {
        string listOfWords = Console.ReadLine();
        char[] separator = { ' ', ',' };
        string[] arrayOfWords = listOfWords.Split(separator,StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(arrayOfWords);
        Console.WriteLine(string.Join("\n",arrayOfWords));
    }
}