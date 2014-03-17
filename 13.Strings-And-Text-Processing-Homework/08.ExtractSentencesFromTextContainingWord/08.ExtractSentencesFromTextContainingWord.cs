//Write a program that extracts from a given text all sentences containing given word.

using System;
class ExtractSentencesFromTextContainingWord
{
    static void Main()
    {
        string text = Console.ReadLine();
        string word=" "+ Console.ReadLine() + " ";
        int position = 0;
        string sentence = string.Empty;
        for (int i = 0; i < text.Length; i=position)
        {
            position=text.IndexOf('.',i)+1;
            sentence = text.Substring(i, position - i);
            if(sentence.IndexOf(word)>0)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}