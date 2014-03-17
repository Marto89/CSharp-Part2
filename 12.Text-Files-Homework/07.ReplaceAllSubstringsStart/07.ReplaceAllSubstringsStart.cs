//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceAllSubstringsStart
{
    static void Main()
    {
        int nRows = int.Parse(Console.ReadLine());

        StreamWriter writer = new StreamWriter("inputFile.txt");
        using (writer)
        {
            for (int i = 0; i < nRows; i++)
            {
                writer.WriteLine(Console.ReadLine());
            }
        }
        StreamReader reader = new StreamReader("inputFile.txt");
        StreamWriter writer2 = new StreamWriter("outputFile.txt");
        using (reader)
        {
            string currentLine = reader.ReadLine();
            using (writer2)
            {
                for (int i = 0; i < nRows; i++)
                {
                    
                    writer2.WriteLine(Regex.Replace(currentLine, "start", "finish"));
                    currentLine = reader.ReadLine();
                }                
            }
        }

    }
}