using System;
using System.Collections.Generic;

class JoroTheRabbit
{
    static void Main()
    {
        char[] separator = { ' ', ',' };
        string[] currentInput = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int maxCount = 0;
        List<int> input = new List<int>();
        foreach (var n in currentInput)
        {
            input.Add(int.Parse(n));
        }
        for (int i = 0; i < currentInput.Length; i++)
        {
            for (int step = 1; step < currentInput.Length; step++)
            {
                int counter = 1;
                int currentElement = i;
                int next = currentElement + step;
                if (next >= input.Count)
                {
                    next = next - input.Count;
                }
                while (input[currentElement] < input[next])
                {
                    counter++;
                    currentElement = next;
                    next = currentElement + step;
                    if (next >= input.Count)
                    {
                        next = next - input.Count;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                }
            }
        }
        Console.WriteLine(maxCount);
    }
}