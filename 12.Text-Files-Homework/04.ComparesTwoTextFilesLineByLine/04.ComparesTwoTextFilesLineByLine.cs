//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;
class ComparesTwoTextFilesLineByLine
{
    static void Main()
    {
        StreamReader reader = new StreamReader("1.txt");
        StreamReader reader2 = new StreamReader("2.txt");

        using(reader)
        {
            using(reader2)
            {
                int counter=0;
                int counter2=0;
                string readLine = reader.ReadLine();
                string readLine2 = reader2.ReadLine();
                while (readLine != null && readLine2 != null)
                {                
                    if (readLine==readLine2)
                    {
                        counter++;
                    }
                    else
                    {
                        counter2++;
                    }
                    readLine = reader.ReadLine();
                    readLine2 = reader2.ReadLine();
                }
                Console.WriteLine(counter);
                Console.WriteLine(counter2);
            }
        }

    }
}