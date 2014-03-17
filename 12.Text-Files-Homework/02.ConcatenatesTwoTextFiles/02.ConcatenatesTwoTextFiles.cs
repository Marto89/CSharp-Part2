//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;
class ConcatenatesTwoTextFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\01.ReadTextAndPrintsOddLines\01.ReadTextAndPrintsOddLines.cs");
        StreamReader reader2 = new StreamReader(@"..\..\02.ConcatenatesTwoTextFiles.cs");
       
        StringBuilder firstText=new StringBuilder();
        using(reader)
        {
            firstText.Append(reader.ReadToEnd());
        }
        StringBuilder secondText = new StringBuilder();
        using(reader2)
        {
            secondText.Append(reader2.ReadToEnd());
        }
        string finalText = "finalText.txt";
        StreamWriter writer = new StreamWriter(finalText);
        using(writer)
        {
            writer.WriteLine(firstText);
            writer.WriteLine();
            writer.WriteLine(new string('-',70));
            writer.WriteLine();
            writer.WriteLine(secondText);
        }
    }   
}