﻿//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

using System;

class TwentyIntegers
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = 5 * i;
        }
        Console.WriteLine(string.Join(", ",numbers));
    }
}

