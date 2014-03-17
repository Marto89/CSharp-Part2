using System;
using System.Text;
using System.Collections.Generic;

class DecodeAndDecrypt
{
    static void Main()
    {
        StringBuilder input = new StringBuilder(Console.ReadLine());

        StringBuilder cypherLength1 = new StringBuilder();
        int start = input.Length - 1;
        while (input[start] >= '0' && input[start] <= '9')
        {
            cypherLength1.Insert(0, (input[start]));
            input.Remove(start, 1);
            start--;
        }
        int cypherLength = int.Parse(cypherLength1.ToString());
        StringBuilder encryptMessage = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= '0' && input[i] <= '9')
            {
                StringBuilder currentPosition = new StringBuilder();
                while (input[i] >= '0' && input[i] <= '9')
                {
                    currentPosition.Append(input[i]);
                    i++;
                }
                encryptMessage.Append(input[i], int.Parse(currentPosition.ToString()));
            }
            else
            {
                encryptMessage.Append(input[i]);
            }
        }
        string cypher = encryptMessage.ToString().Substring(encryptMessage.Length - cypherLength);
        encryptMessage.Remove(encryptMessage.Length - cypherLength, cypherLength);

        List<char> answer = new List<char>(encryptMessage.ToString());
        for (int i = 0; i < Math.Max(cypher.Length, encryptMessage.Length); i++)
        {
            answer[i % answer.Count] = (char)((((cypher[i % cypherLength] - 'A') ^ (answer[i % answer.Count] - 'A')) + 'A'));
        }
        Console.WriteLine(string.Join("", answer));
    }
}