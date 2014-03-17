//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

class ArrayWithAlphabetLetters
{
    static void Main()
    {
        string inputWord = Console.ReadLine();

        char [] alphabetLetters=new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabetLetters[i] = (char)(i+65);
        }
        for (int i = 0; i < inputWord.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (inputWord[i] == alphabetLetters[j])
                {
                    Console.Write("{0} ",j);
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}
