//A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. 

using System;

class EncyclopedicDictionary
{
    static void Main()
    {
        int nNumbers = int.Parse(Console.ReadLine());

        string [] sentences=new string[nNumbers];
        for (int i = 0; i < nNumbers; i++)
        {
            sentences[i] = Console.ReadLine();
        }
        string seekingWord = Console.ReadLine();
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(seekingWord)==0)
            {
                Console.WriteLine(sentences[i].Substring(sentences[i].IndexOf('-')+2));
            }
        }

    }
}