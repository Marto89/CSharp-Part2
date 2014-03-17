//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        int findingNumber = int.Parse(Console.ReadLine());
        char[] delimiter = new char[] {',',' '};
        string[] inputArrayTwo = inputArrayOne.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        int []realArray=new int[inputArrayTwo.Length];
        for (int i = 0; i < inputArrayTwo.Length; i++)
        {
            realArray[i] = int.Parse(inputArrayTwo[i]);
        }
        Array.Sort(realArray);
        int left = 0;
        int right = realArray.Length-1;
        int middle;
        while (left<=right)
        {
            middle = (left + right) / 2;
            if (realArray[middle] == findingNumber)
            {
                Console.WriteLine(middle);
                return;
            }
            if (realArray[middle]>findingNumber)
            {
                right = middle - 1;
            }
            if (realArray[middle] < findingNumber)
            {
               left=middle+1;
            }
        }
        Console.WriteLine("Not Found!");
    }
}
