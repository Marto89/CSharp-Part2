//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        string filePath="inputFile.txt";
        StreamReader reader = new StreamReader(filePath);
        List<string> array=new List<string>();

        using (reader)
        {
            int number = 0;
            string currentLine=reader.ReadLine();
            while(currentLine!=null)
            {
                number++;
                if(number%2==0)
                {
                    array.Add(currentLine);
                }
                currentLine = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(filePath);

        using (writer)
        {
            for (int i = 0; i < array.Count; i++)
            {
                writer.WriteLine(array[i]);
            }
        }
    }
}