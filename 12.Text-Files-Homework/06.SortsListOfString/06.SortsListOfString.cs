//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George			Peter

using System;
using System.IO;
class SortsListOfString
{
    static void Main()
    {
        int nNames = int.Parse(Console.ReadLine());
        string[] array=new string[nNames];
        StreamWriter writer = new StreamWriter("inputFile.txt");
        using(writer)
        {
            for (int i = 0; i < nNames; i++)
            {
                writer.WriteLine(Console.ReadLine());
            }
        }
        StreamReader reader = new StreamReader("inputFile.txt");
        using (reader)
        {
            for (int i = 0; i < nNames; i++)
            {
                array[i] = reader.ReadLine();
            }
            Array.Sort(array);
        }
        StreamWriter writer2 = new StreamWriter("outputFile.txt");
        using (writer2)
        {
            for (int i = 0; i < nNames; i++)
            {
                writer2.WriteLine(array[i]);
            }
        }
    }
}