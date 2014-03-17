//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;
using System.Collections.Generic;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] {',',' '};
        string[] inputOne =inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            arr[i] = int.Parse(inputOne[i]);
        }
        int counter = 1;
        int maxValue = 0;
        int sequenceDigit = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                if (counter > maxValue)
                {
                    sequenceDigit = arr[i];
                }
                maxValue = Math.Max(maxValue, counter);
            }
            else
            {
                counter = 1;
            }
        }
        for (int i = 0; i < maxValue; i++)
        {
            if (i >= 1)
            {
                Console.Write(", ");
            }
            Console.Write(sequenceDigit);
        }
        Console.WriteLine();
    } 
}
