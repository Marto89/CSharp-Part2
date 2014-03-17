//Write a program that finds in given array of integers a sequence of given sum S (if present). Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] {',',' '};
        string[] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int[]realArray=new int[inputArrayTwo.Length];
        for (int i = 0; i < inputArrayTwo.Length; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
        }
        int currentSum=0;
        int sumOfAll = 0;
        for (int i = 0; i < realArray.Length; i++)
        {
            sumOfAll += realArray[i];
            if (i == realArray.Length - 1 && sumOfAll<s)
            {
                Console.WriteLine("There is no sequence of given sum!");
            }
            currentSum = 0;
            for (int j = i; j < realArray.Length; j++)
            {
                currentSum += realArray[j];
                if (currentSum == s)
                {
                    for (int n = i; n <=j; n++)
                    {
                        if (n >= i + 1)
                        {
                            Console.Write(", ");
                        }
                        Console.Write(realArray[n]);
                    }
                    currentSum=0;
                    Console.WriteLine();
                    break;
                }
                if (currentSum > s)
                {
                    currentSum = 0;
                    break;
                }
            }
        }
    }
}
