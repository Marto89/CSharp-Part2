//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

class XMLFileWithoutTheTags
{
    static void Main()
    {
        StreamReader reader = new StreamReader("inputFile.xml");
        using (reader)
        {
            string text = reader.ReadToEnd();
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == '>'&& text[i+1]!='<')
                {
                    while (text[i] != '<' && i<text.Length-1)
                    {
                        i++;
                        if(text[i]!='<')
                        {
                            Console.Write(text[i]);
                        }
                    }
                    if (text[i - 1] != '>')
                    {
                        Console.WriteLine();
                    }
                }       
            }                                    
        }
    }
}