/*
 * Write a program that reverses the words in given sentence.
	Example: "C# is not C++ and PHP is not Delphi"  "Delphi not is PHP and C++ not is C#".
  */
using System;

class ReversesTheWordsInSentence
{
	static void Main()
	{
		string sentence = Console.ReadLine();
		char[] separator = { ' ', '\"' };
		string[] array = sentence.Split(separator,StringSplitOptions.RemoveEmptyEntries);
		Array.Reverse(array);
		Console.WriteLine("\"{0}\"",string.Join(" ",array));
	}
}