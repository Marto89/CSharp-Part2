//Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
using System;

class FindMaxInArrayAndSort
{
    static int FindMaxInArray(int[]array,int startPosition)
    {
        if(startPosition>array.Length)
        {
            return -1;
        }
        int maxElement = array[startPosition];
        for (int i = startPosition+1; i < array.Length; i++)
        {
            if(array[i]>maxElement)
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }
    static int FindMinInArray(int[] array, int startPosition)
    {
        if (startPosition > array.Length)
        {
            return -1;
        }
        int minElement = array[startPosition];
        for (int i = startPosition + 1; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }
        return minElement;
    }
    static void DescendingArray(int []array)
    {
        int[] descendingArray=new int [array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            descendingArray[i] = FindMaxInArray(array, i);
            for (int j = 0; j < array.Length; j++)
            {
                if(descendingArray[i]==array[j])
                {
                    array[j] = array[i];
                    array[i] = descendingArray[i];
                    break;
                }
            }
        }
        foreach (var n in descendingArray)
        {
            Console.Write(n+" ");
        }
        Console.WriteLine();
    }
    static void AscendingArray(int []array)
    {
        int[] ascendingArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            ascendingArray[i] = FindMinInArray(array, i);
            for (int j = 0; j < array.Length; j++)
            {
                if(ascendingArray[i]==array[j])
                {
                    array[j] = array[i];
                    array[i] = ascendingArray[i];
                    break;
                }
            }
        }
        foreach (var n in ascendingArray)
        {
            Console.Write(n+" ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter a number of integers:");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter {0} integer:",i+1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the start position:");
        int startPosition = int.Parse(Console.ReadLine());

        Console.WriteLine(FindMaxInArray(array,startPosition));
        DescendingArray(array);
        AscendingArray(array);
    }
}