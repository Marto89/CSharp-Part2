//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

using System;
using System.Text;

class ExtractHTMLTextWithoutTags
{
    static void Main()
    {
        StringBuilder text=new StringBuilder();
        string line = string.Empty;
        do 
        {
            line = Console.ReadLine();
            text.Append(line);
            line = line.ToLower();
        } while (line != "</html>");
        Console.WriteLine();
        for (int i = 0; i < text.Length-1; i++)
        {
    
            if(text[i]=='>'&&text[i+1]!='<')
            {
                i++;
                while(i<text.Length-1 && text[i]!='<')
                {
                    Console.Write(text[i]);
                    i++;
                }
                Console.WriteLine();
            }
        }

    }
}