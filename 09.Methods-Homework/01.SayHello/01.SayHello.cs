//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
using System;

public class SayHello
{
    public static string PrintName(string name )
    {
        string greeting = "Hello, " + name+"!";
        return greeting;          
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(PrintName(name));
    }
}