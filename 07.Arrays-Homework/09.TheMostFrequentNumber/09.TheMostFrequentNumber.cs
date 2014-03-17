//Write a program that finds the most frequent number in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).

using System;

class TheMostFrequentNumber
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] {',',' '};
        string[] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int[]realArray=new int[inputArrayTwo.Length];
        for (int i = 0; i < inputArrayTwo.Length; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
        }
        int frequentNumber = 0;
        int maxFrequent = 1;
        int counter = 1;
        for (int i = 0; i < realArray.Length; i++)
        {
            for (int j = i+1; j < realArray.Length; j++)
            {
                if (realArray[i] == realArray[j])
                {
                    counter++;
                }
            }
            if (maxFrequent < counter)
            {
                frequentNumber = i;
            }
            maxFrequent = Math.Max(maxFrequent, counter);
            counter = 1;
        }
        Console.WriteLine("{0}({1} times)", realArray[frequentNumber], maxFrequent);
    }
}
