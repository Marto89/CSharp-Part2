//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortTheStringArrayByItsLength
{
	static void Main()
	{
		string[] stringArray = {"book","programmer","computer","science","short","integer","byte","sbyte"};

		int [] intArray=new int [stringArray.Length];
		for (int i = 0; i < stringArray.Length; i++)
		{
			intArray[i] = stringArray[i].Length;
		}
		Array.Sort(intArray);

		string [] finalArray=new string[stringArray.Length];
		for (int i = 0; i < stringArray.Length; i++)
		{
			for (int j = 0; j < intArray.Length; j++)
			{
				if (stringArray[j].Length == intArray[i])
				{
					finalArray[i] = stringArray[j];
					stringArray[j] = string.Empty;
					break;
				}
			}
		}
		Console.WriteLine(string.Join(",",finalArray));
	}
}
