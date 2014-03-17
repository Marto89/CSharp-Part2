//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

using System;
using System.Text.RegularExpressions;

class ReplacesInAHTMLDocument
{
    static void Main()
    {
        string html = Console.ReadLine();
        html = html.Replace("<a href=\"", "[URL=");
        html = html.Replace("\">", "]");
        html = html.Replace("</a>", "[/URL]");
        Console.WriteLine();
        Console.WriteLine(html);
    }
}