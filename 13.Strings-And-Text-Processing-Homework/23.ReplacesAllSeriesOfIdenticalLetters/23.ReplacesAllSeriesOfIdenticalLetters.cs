//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class ReplacesAllSeriesOfIdenticalLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            int currentPosition = i;
            int counter = 0;
            while(currentPosition<text.Length-1 &&text[currentPosition]==text[currentPosition+1])
            {
                counter++;
                currentPosition++;
            }
            text = text.Remove(i , counter);
        }
        Console.WriteLine(text);
    }
}