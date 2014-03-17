using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int nNumber = int.Parse(Console.ReadLine());
        List<string> allWords = new List<string>(1000);
        int maxLength = 0;
        for (int i = 0; i < nNumber; i++)
        {
            allWords.Add(Console.ReadLine());
            if (allWords[i].Length > maxLength)
            {
                maxLength = allWords[i].Length;
            }
        }
        StringBuilder currentWords = new StringBuilder();
        for (int i = 0; i < nNumber; i++)
        {
            currentWords.Append(allWords[i]);
            allWords[i] = null;
            allWords.Insert(currentWords.Length%(nNumber+1), currentWords.ToString());
            allWords.Remove(null);
            currentWords.Clear();
        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (var n in allWords)
            {               
                if(i<n.Length)
                {                    
                    result.Append(n[i]);
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}