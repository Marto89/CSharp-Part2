//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. 

using System;
using System.Text;
class ForbiddenWordsWithAsterisks
{
    static void Main()
    {
        string text = Console.ReadLine();
        string words = Console.ReadLine();
        char[] split = { ',',' ' };
        string[] forbiddenWords = words.Split(split,StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            StringBuilder asteriks = new StringBuilder();
            for (int j = 1; j <=forbiddenWords[i].Length; j++)
            {
                asteriks.Append('*');
            }
            text=text.Replace(forbiddenWords[i],asteriks.ToString());
        }
        Console.WriteLine(text);
    }
}