//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;

class PrintsAllDifferentLettersInTheString
{
    static void Main()
    {
        char [] text = Console.ReadLine().ToCharArray();
        Array.Sort(text);
        for (int i = 0; i < text.Length; i++)
        {
            int counter=1;
           while(i<text.Length-1 && text[i]==text[i+1])
           {
               counter++;
               i++;
           }
           Console.WriteLine("{0}->{1}times",text[i],counter);
        }
    }
}