using System;

class DurankulakNumbers
{
    static long DurankulakNumber(string input)
    {
        if(input.Length>1)
        {
            return (input[0] - 96) * 26 + (input[1] - 65);
        }
        else
        {
            return (input[0] - 65);
        }
    }
    static void Main()
    {
        string input = Console.ReadLine();
        long answer = 0;

        for (int i = 0; i < input.Length; i++)
        {
            answer *= 168;
            if(char.IsLower(input[i]))
            {
                answer += DurankulakNumber(input.Substring(i,2));
                i++;
            }
            else
            {
                answer += DurankulakNumber(input[i].ToString());
            }          
        }
        Console.WriteLine(answer);
    }
}