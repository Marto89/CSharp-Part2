using System;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arrayWithWords = input.Split(' ');
        int maxLength = 0;
        foreach (var n in arrayWithWords)
        {
            if (maxLength < n.Length)
            {
                maxLength = n.Length;
            }
        }
        StringBuilder finalWord = new StringBuilder();       
        for (int i = 0; i < maxLength; i++)
        {
            for (int j = 0; j < arrayWithWords.Length; j++)
            {
                if (i < arrayWithWords[j].Length)
                {
                    finalWord.Append(arrayWithWords[j][arrayWithWords[j].Length - i - 1]);
                }
            }
        }
        for (int i = 0; i < finalWord.Length; i++)
        {
            char letter;
            letter = finalWord[i];
            finalWord.Remove(i, 1);
            if (char.IsLower(letter))
            {
                finalWord.Insert(((int)letter - 96 + i) % (finalWord.Length + 1), letter);
            }
            else
            {
                finalWord.Insert(((int)letter - 64 + i) % (finalWord.Length + 1), letter);
            }
        }
        Console.WriteLine(finalWord);
    }
}