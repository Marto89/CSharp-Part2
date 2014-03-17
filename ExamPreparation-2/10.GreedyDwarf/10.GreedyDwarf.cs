using System;

class GreedyDwarf
{
    static void Main()
    {
        char[] separator = { ',', ' ' };
        string[] realValley = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

        int m = int.Parse(Console.ReadLine());
        int maxSum = int.MinValue;
        for (int i = 0; i < m; i++)
        {
            int valleyIndex = 0;
            string[] valley = new string[realValley.Length];
            Array.Copy(realValley, valley, realValley.Length);
            int currentSum = int.Parse(valley[0]);
            int patternCounter = 0;
            string[] currentPattern = (Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries));
            do
            {
                valleyIndex = int.Parse(currentPattern[patternCounter % currentPattern.Length]) + valleyIndex;
                if (valleyIndex > 0 && valleyIndex < valley.Length && valley[valleyIndex] != null)
                {
                    currentSum += int.Parse(valley[valleyIndex]);
                    valley[valleyIndex] = null;
                }
                else
                {
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                    break;
                }
                patternCounter++;
            } while (valleyIndex > 0 && valleyIndex < valley.Length);
        }
        Console.WriteLine(maxSum);
    }
}