using System;
using System.Text;
using System.Linq;

class BasicLanguage
{
    static int For(string input)
    {
        while (true)
        {
            
        }
    }
     static void Main()
    {
        StringBuilder input = new StringBuilder();
        while (input.ToString().IndexOf("EXIT;")<0)
        {
            input.Append(Console.ReadLine());
        }
         string allText=input.ToString();
         string[] lines = allText.Split(';');
         Console.WriteLine(string.Join("\n",lines));
    }
}