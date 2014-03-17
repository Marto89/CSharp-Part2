//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ComparesTwoIntegerArrays
{
    static void Main()
    {
        //Each array is inserted on one line and every element of the array is created with space between them.
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("false");
            return;
        }

        for (int i = 0; i < firstArray.Length; i+=2)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("false");
                return;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("true");
    }
}
