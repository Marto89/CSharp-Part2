//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;
class DeletePrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        string text;
        using (reader)
        {
            text = reader.ReadToEnd();

        }
        text = Regex.Replace(text, @"\btest\w+", "");
        text = Regex.Replace(text, @"\btest\b", "");
        StreamWriter writer = new StreamWriter("input.txt");
        using (writer)
        {
            writer.Write(text);
        }       
    }
}