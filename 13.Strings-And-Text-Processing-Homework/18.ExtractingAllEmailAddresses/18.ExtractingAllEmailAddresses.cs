using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
	class EmailsExtractor
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string[] words = text.Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				if (TestEmailRegex(words[i]))
				{
					Console.WriteLine(words[i]);
				}
			}
		}

		static bool TestEmailRegex(string emailAddress)
		{
			string patternStrict = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
				 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
				+ @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
				+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

			Regex reStrict = new Regex(patternStrict);

			bool isStrictMatch = reStrict.IsMatch(emailAddress);

			return isStrictMatch;
		}
	}
}
