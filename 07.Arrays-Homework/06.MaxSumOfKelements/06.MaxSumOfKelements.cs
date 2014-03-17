//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

class MaxSumOfKelements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        string inputArrayOne = Console.ReadLine();
        char [] delimiter = new char[] {' '};
        string [] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int[] realArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
        }
        Array.Sort(realArray);
        for (int i = realArray.Length- 1; i >(realArray.Length-1)-k; i--)
        {
            if (i < realArray.Length - 1)
            {
                Console.Write(", ");
            }
            Console.Write(realArray[i]);
        }
        Console.WriteLine();
    }
}
