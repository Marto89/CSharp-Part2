//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char [] {',',' '};
        string [] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int[] realArray = new int[inputArrayTwo.Length];
        for (int i = 0; i < inputArrayTwo.Length; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
        }

        int counter = 0;
        int sequenceDigit = 0;
        int maxValue = 0;

        for (int i = 0; i < realArray.Length-1; i++)
        {
            if (realArray[i] < realArray[i + 1])
            {
                counter++;
                if (maxValue < counter)
                {
                    sequenceDigit = i;
                    sequenceDigit++;
                }
                maxValue = Math.Max(maxValue, counter);
            }
            else
            {
                counter = 0;
            }
        }
        int[] finalArray = new int[maxValue+1];
        int j = 0;
        for (int i = sequenceDigit-maxValue; i <=sequenceDigit; i++,j++)
        {
            finalArray[j] = realArray[i];
        }
        if (maxValue!=0)
        {
            Console.WriteLine(string.Join(", ", finalArray));
        }
        else
        {
            Console.WriteLine("The array doesn't have an increasing sequence!");
        }
    }
}
