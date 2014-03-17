using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RelevanceIndex
{
    static void Main()
    {
        StringBuilder searchWord = new StringBuilder(Console.ReadLine().ToLower());
        for (int i = 0; i < searchWord.Length; i++)
        {
            if (searchWord[i] == ' ')
            {
                searchWord.Remove(i, 1);
            }
        }
        int l = int.Parse(Console.ReadLine());

        string[] allLines = new string[l];

        for (int i = 0; i < l; i++)
        {
            var sb = new StringBuilder();
            string[] currentRow = Console.ReadLine().Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < currentRow.Length; j++)
            {
                if (currentRow[j].ToLower() == searchWord.ToString())
                {
                    sb.Append(currentRow[j].ToUpper());
                }
                else
                {
                    sb.Append(currentRow[j]);
                }
                sb.Append(" ");
            }
            allLines[i] = sb.ToString();
        }
        int[] sortArray = new int[l];

        string pattern = searchWord.ToString();
        pattern = pattern.ToUpper();
        for (int i = 0; i < allLines.Length; i++)
        {
            sortArray[i] = Regex.Matches(allLines[i], pattern).Count;
        }
        Array.Sort(sortArray, allLines);
        Array.Reverse(allLines);
        Console.WriteLine(string.Join("\n", allLines));
    }
}