//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ComparesTwoCharArrays
{
    static void Main()
    {
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        int length = Math.Min(firstArray.Length,secondArray.Length);

        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} is first lexicographically!",secondArray);
                return;
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} is first lexicographically!",firstArray);
                return;
            }
        }
        if (firstArray.Length == secondArray.Length)
        {
            Console.WriteLine("No difference!");
        }
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("{0} is first lexicographically!", secondArray);
        }
        if(firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("{0} is first lexicographically!", firstArray);
        }
    }
}
