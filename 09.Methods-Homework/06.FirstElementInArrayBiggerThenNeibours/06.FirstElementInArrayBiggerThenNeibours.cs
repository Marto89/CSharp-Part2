//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstElementInArrayBiggerThenNeiboursProgram
{
    static int FirstBiggerElement(int[]array)
    {
        for (int i = 1; i < array.Length-1; i++)
        {
            if(array[i]>array[i-1] && array[i]>array[i+1])
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        Console.Write("How many numbers you want to input:");
        int numberOfIntegers = int.Parse(Console.ReadLine());

        int[] integerArray = new int[numberOfIntegers];
        for (int i = 0; i < integerArray.Length; i++)
        {
            Console.Write("Input {0} Numbers:", i + 1);
            integerArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(FirstBiggerElement(integerArray));
    }
}
