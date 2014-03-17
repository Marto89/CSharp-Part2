//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSortAlgorithm
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int [] array=new int [n];
        int[] newArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            for (int j = i+1; j < n; j++)
            {
                minValue = Math.Min(array[i], array[j]);
                maxValue = Math.Max(array[i], array[j]);
                array[i] = minValue;
                array[j] = maxValue;
            }          
        }
        Console.WriteLine(string.Join(" ",array));
    }
}
