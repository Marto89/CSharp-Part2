using System;
using System.Text;

class StrangeLandNumbers
{
    static void Main()
    {
        string[] array = {"f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT"};
        string input = Console.ReadLine();

        StringBuilder currentWord = new StringBuilder();
        ulong answer = 0;
        for (int i = 0; i < input.Length; i++)
        {
            currentWord.Append(input[i]);
            for (int j = 0; j < array.Length; j++)
            {
                if (currentWord.ToString() == array[j])
                {
                    answer *= 7;
                    answer += (ulong)j;
                    currentWord = new StringBuilder();
                    break;
                }
            }
        }
        Console.WriteLine(answer);
    }
}