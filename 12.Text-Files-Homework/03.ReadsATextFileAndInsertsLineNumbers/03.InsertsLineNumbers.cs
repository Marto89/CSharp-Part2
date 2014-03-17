//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

using System;
using System.IO;
class InsertsLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\03.InsertsLineNumbers.cs");
        string finalText="finalText.txt";
        StreamWriter writer = new StreamWriter(finalText);
        using(writer)
        {
            string currentText=reader.ReadLine();
            int line=0;
            while(currentText!=null)
            {
                line++;
                writer.WriteLine("{0}. {1}",line,currentText);
                currentText = reader.ReadLine();
            }
        }
    }
}