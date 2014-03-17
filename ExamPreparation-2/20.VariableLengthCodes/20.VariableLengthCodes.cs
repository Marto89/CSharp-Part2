using System;
using System.Text;

class VariableLengthCodes
{
    static void Main()
    {
        string[] allNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] allIntegers = new int[allNumbers.Length];
        for (int i = 0; i < allNumbers.Length; i++)
        {
            allIntegers[i] = int.Parse(allNumbers[i]);
        }
        var bitSequence = new StringBuilder();
        for (int i = 0; i < allNumbers.Length; i++)
        {
            bitSequence.Append(Convert.ToString(allIntegers[i], 2));
        }
        int l = int.Parse(Console.ReadLine());
        char[]arrayWithLetters=new char[l+1];
        arrayWithLetters[0] = ' ';
        for (int i = 0; i < l; i++)
        {
            StringBuilder currentWord = new StringBuilder(Console.ReadLine());
            var currentLetter = new StringBuilder(currentWord.ToString());
            currentWord.Remove(0, 1);
            arrayWithLetters[int.Parse(currentWord.ToString())] = currentLetter[0];
        }

        for (int i = 0; i < bitSequence.Length; i++)
        {
            int counter = 0;
            while (i<bitSequence.Length-1 && bitSequence[i]!='0')
            {
                counter++;
                i++;
            }
            Console.Write(arrayWithLetters[counter]);
        }
        Console.WriteLine();
    }
}