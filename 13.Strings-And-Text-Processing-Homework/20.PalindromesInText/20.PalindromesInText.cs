//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class PalindromesInTextProgram
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] separator = { ' ',',','.','!','?',':',';'};
        string[] allWords = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < allWords.Length; i++)
        {
            int counter = 0;
            char[] word=allWords[i].ToLower().ToCharArray();
            for (int j = 0; j < word.Length; j++)
            {               
                if(word[j]==word[word.Length-1-j])
                {
                    counter++;
                }
            }
            if(counter==(allWords[i].Length)&&counter!=1)
            {
                Console.WriteLine(allWords[i]);
            }           
        }
    }
}