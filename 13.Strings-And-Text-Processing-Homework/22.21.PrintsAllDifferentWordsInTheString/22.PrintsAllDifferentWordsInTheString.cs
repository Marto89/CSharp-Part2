//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;

class PrintsAllDifferentWordsInTheString
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] separator = { ' ','.',',','!','?',':',';'};
        string[] allWords = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(allWords);
        for (int i = 0; i < allWords.Length; i++)
        {
            int counter=1;
            while(i<allWords.Length-1 && allWords[i]==allWords[i+1])
            {
                counter++;
                i++;
            }
            Console.WriteLine("{0}->{1}times",allWords[i],counter);
        }
    }
}