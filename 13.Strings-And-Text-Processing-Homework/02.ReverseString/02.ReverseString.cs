//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        char []answer=input.ToCharArray();
        Array.Reverse(answer);
        Console.WriteLine(answer);
    }
}