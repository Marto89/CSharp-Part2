using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static List<string> ConvertToList(int n, List<string> list)
    {
        string[] currentRow;
        for (int i = 0; i < n; i++)
        {
            currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < currentRow.Length; j++)
            {
                list.Add(currentRow[j]);
            }
        }
        return list;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        List<string> allWords = new List<string>();
        allWords = ConvertToList(n, allWords);

        for (int i = 0; i < allWords.Count - 1; i++)
        {
            var line = new StringBuilder(allWords[i]);
            int wordsOnRow = 1;
            while (i < allWords.Count - 1 && line.Length + allWords[i + 1].Length + 1 <= w)
            {
                wordsOnRow++;
                i++;
                line.Append(" ");
                line.Append(allWords[i]);
            }
            if (line.Length < w)
            {
                int index = 0;
                while (line.Length != w && wordsOnRow != 1)
                {
                    index++;
                    if (index == line.Length - 1)
                    {
                        index = 0;
                    }
                    if (line[index] == ' ' && line[index + 1] != ' ')
                    {
                        line.Insert(index, ' ');
                        index++;
                    }
                }
            }
            Console.WriteLine(line.ToString());
            if (i == allWords.Count - 2)
            {
                Console.WriteLine(allWords[allWords.Count - 1]);
            }
        }
    }
}