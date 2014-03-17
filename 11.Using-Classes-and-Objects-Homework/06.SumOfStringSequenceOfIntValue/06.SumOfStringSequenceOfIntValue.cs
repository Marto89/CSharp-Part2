//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461

using System;
using System.Text;

class SumOfStringSequenceOfIntValue
{
    static void Main()
    {
        string input = Console.ReadLine();
        input += " ";
        int answer=0;
        for (int i = 0; i < input.Length; i++)
        {
            StringBuilder currentNumber = new StringBuilder();
            while (input[i] > 47 && input[i] < 58 && i <= input.Length-1)
            {          
                currentNumber.Append(input[i]);
                i++;
            }
                answer += int.Parse(currentNumber.ToString());
        }
        Console.WriteLine(answer);
    }
}