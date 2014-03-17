//Write a program that finds the sequence of maximal sum in given array. Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} 

using System;

class TheSequenceOfMaxSum
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] {',',' '};
        string [] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
        
        int[]realArray=new int[inputArrayTwo.Length];
        int currentSum = 0;
        int maxSum = 0;
        int counter = 1;
        int arrayNumber = 0;
        for (int i = 0; i < inputArrayTwo.Length; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
            currentSum += realArray[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                counter++;
                arrayNumber = i;
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                counter = 1;
            }
            if (i == inputArrayTwo.Length - 1)
            {
                for (int j = arrayNumber-counter; j <=arrayNumber; j++)
                {
                    Console.Write(realArray[j]);
                    if (j < arrayNumber)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
