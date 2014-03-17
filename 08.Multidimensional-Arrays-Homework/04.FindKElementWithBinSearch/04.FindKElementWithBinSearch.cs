//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class FindKElementWithBinSearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        string[] splitArray = inputArray.Split(' ');
        int [] realArray=new int[n];
        for (int i = 0; i < n; i++)
        {
            realArray[i] = int.Parse(splitArray[i]);
        }
        Array.Sort(realArray);
        int seekingNumber = Array.BinarySearch(realArray,k);
        if (realArray[0] > k)
        {
            Console.WriteLine("There isn't such a number in the array.");
        }
        else
        {
            if (seekingNumber < 0)
            {
                seekingNumber = -seekingNumber - 2;
                Console.WriteLine(realArray[seekingNumber]);
            }
            else
            {
                Console.WriteLine(realArray[seekingNumber]);
            }
        }
    }
}
