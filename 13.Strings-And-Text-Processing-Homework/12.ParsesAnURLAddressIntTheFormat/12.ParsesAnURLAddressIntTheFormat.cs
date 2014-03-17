//Write a program that parses an URL address given in the format.

using System;

class ParsesAnURLAddressIntTheFormat
{
	static void Main()
	{
		string url = Console.ReadLine();
		int startPosition = 0;
		int endPosition = 0;
		endPosition = url.IndexOf(@"://", startPosition);
		string protocol = url.Substring(startPosition,endPosition-startPosition);
		startPosition = endPosition + 3;
		endPosition = url.IndexOf(@"/",startPosition);
		string server = url.Substring(startPosition, endPosition - startPosition);
		string resource = url.Substring(endPosition);
		Console.WriteLine("\"[protocol] = \"{0}\"",protocol);
		Console.WriteLine("\"[protocol] = \"{0}\"",server);
		Console.WriteLine("\"[protocol] = \"{0}\"",resource);
	}
}