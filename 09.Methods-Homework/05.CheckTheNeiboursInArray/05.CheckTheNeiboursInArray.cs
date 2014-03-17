//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class CheckTheNeiboursInArray
{
    static string CheckTheNeibours(int[] array, int position)
    {
        if (position == 0)
        {
           return "This is first element!";
        }
        else if (position == array.Length - 1)
        {
            return "This is last element!";
        }
        else if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            return "The element is bigger then neibours!";
        }
        return "The element isn't bigger then neibours!";
    }
    static void Main()
    {
        Console.Write("How many numbers you want to input:");
        int numberOfIntegers = int.Parse(Console.ReadLine());

        int [] integerArray=new int [numberOfIntegers];
        for (int i = 0; i < integerArray.Length; i++)
        {
            Console.Write("Input {0} Numbers:",i+1);
            integerArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Input the positon to check:");
        int position = int.Parse(Console.ReadLine());

        if(position<0 || position>integerArray.Length-1)
        {
            throw new Exception("Wrong position!");
        }

        Console.WriteLine(CheckTheNeibours(integerArray,position));
    }
}