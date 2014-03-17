using System;
using System.Text;

class GagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] digits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        StringBuilder currentWord = new StringBuilder();
        ulong answer = 0;
        for (int i = 0; i < input.Length; i++)
        {
            currentWord.Append(input[i]);
            for (int j = 0; j < digits.Length; j++)
            {
                if (currentWord.ToString() == digits[j])
                {
                    answer *= 9;
                    answer += (ulong)j;
                    currentWord = new StringBuilder();
                    break;
                }
            }
        }
        Console.WriteLine(answer);
    }
}