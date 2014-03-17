using System;
using System.Collections.Generic;

class Zerg
{
    static void Main()
    {
        var alphabet = new List<string>(){ "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        var input = Console.ReadLine();
    
        long answer=0;
        for (int i = 0; i < input.Length; i+=4)
        {
            var word = input.Substring(i, 4);
            var decimalRepresentation = alphabet.IndexOf(word);
            answer *= 15;
            answer += decimalRepresentation;
        }
        Console.WriteLine(answer);
    }
}