//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        int[] array = new int[10000001];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        int max = (int)Math.Sqrt(array.Length);
        for (int i = 2; i < max; i++)
        {
            if (array[i] != 0)
            {
                for (int j = i+i; j < array.Length; j += i)
                {
                    array[j] = 0;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
