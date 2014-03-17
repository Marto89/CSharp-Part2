//Write a method that counts how many times given number appears in given array. 
using System;

public class CountNumInArray
{
    public static int CountNum(int [] array,int number)
    {
        int counter = 0;
        foreach (var n in array)
        {
            if (n == number)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("How many number you want to input:");
        int numberOfIntegers = int.Parse(Console.ReadLine());
        int [] integerArray=new int [numberOfIntegers];
        for (int i = 0; i < numberOfIntegers; i++)
        {
            Console.Write("Input number {0}:",i+1);
            integerArray[i] = int.Parse(Console.ReadLine());
        }    
        Console.Write("Number to search for:");
        int seekingNumber = int.Parse(Console.ReadLine());

        int result = CountNum(integerArray, seekingNumber);
        Console.WriteLine("Found {0} times!",result);
    }
}
