//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;

public class SumTwoBigIntegers
{
    public static int[] SumOfArray(int[] firstArray, int[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        int maxLength = Math.Max(firstArray.Length, secondArray.Length);
        int[] realArray = new int[maxLength];
        int[] finalArray = new int[maxLength + 1];
        if (firstArray.Length > secondArray.Length)
        {
            Array.Copy(secondArray, realArray, secondArray.Length);
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(firstArray[i] + realArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
            if (counter == 1)
            {
                finalArray[finalArray.Length - 1] = 1;
            }
            return finalArray;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Array.Copy(firstArray, realArray, firstArray.Length);
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(realArray[i] + secondArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
            return finalArray;
        }
        else
        {
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(firstArray[i] + secondArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
        }
        return finalArray;
    }
    public static int[] ToArray(string number)
    {
        int[] array = new int[number.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number[i] - 48;
        }
        return array;
    }
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        int[] firstArray, secondArray;
        firstArray = ToArray(firstNumber);
        secondArray = ToArray(secondNumber);
        int[] finalArray = SumOfArray(firstArray, secondArray);
        if (finalArray[finalArray.Length - 1] == 0)
        {
            for (int i = finalArray.Length - 2; i >= 0; i--)
            {
                Console.Write(finalArray[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = finalArray.Length - 1; i >= 0; i--)
            {
                Console.Write(finalArray[i]);
            }
            Console.WriteLine();
        }
    }
}