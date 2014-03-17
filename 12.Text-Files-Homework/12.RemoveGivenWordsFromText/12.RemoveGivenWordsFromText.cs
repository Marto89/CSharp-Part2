//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RemoveGivenWordsFromText
{
	static void Main()
	{
		try
		{
			StreamReader reader = new StreamReader("words.txt");
			List<string> list = new List<string>();
			using (reader)
			{
				string currentRow = reader.ReadLine();
				while (currentRow != null)
				{
					list.Add(" " + currentRow + " ");
					currentRow = reader.ReadLine();
				}
			}
			StreamReader reader2 = new StreamReader("text.txt");
			string text = string.Empty;
			using (reader2)
			{
				text = " " + reader2.ReadToEnd();
			}
			for (int i = 0; i < list.Count; i++)
			{
				text = Regex.Replace(text, list[i], " ");
			}
			StreamWriter writer = new StreamWriter("answer.txt");
			using (writer)
			{
				writer.Write(text);
			}
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (FileLoadException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (FieldAccessException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (IOException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (OutOfMemoryException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}