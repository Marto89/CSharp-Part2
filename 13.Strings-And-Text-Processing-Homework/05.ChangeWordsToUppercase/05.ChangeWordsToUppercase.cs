//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

using System;
class ChangeWordsToUppercase
{
	static void Main()
	{
		string input = Console.ReadLine();
		int startPosition = 0;
		int endPostion = 0;
		string upCase = string.Empty;
		while (startPosition < input.LastIndexOf("<upcase>"))
		{
			startPosition = input.IndexOf("<upcase>");
			endPostion = input.IndexOf("</upcase>")+9;
			upCase = input.Substring(startPosition+8, endPostion-9-(startPosition+8)).ToUpper();
			input = input.Replace(input.Substring(startPosition,endPostion-startPosition), upCase);
			startPosition ++;
		}
		Console.WriteLine(input);
	}
}