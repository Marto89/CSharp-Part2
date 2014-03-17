//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class ConvertFromAnyNumeralSystem
{
    static void PrintResult(string finalAnswer)
    {
        for (int i = finalAnswer.Length - 1; i >= 0; i--)
        {
            Console.Write(finalAnswer[i]);
        }
        Console.WriteLine();
    }
    static int ConvertToDecimal(string number,int input)
    {
        int result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] < 58)
            {
                result += (number[i] - 48) * (int)(Math.Pow(input, number.Length - 1 - i));
            }
            else
            {
                result += (number[i] - 55) * (int)(Math.Pow(input, number.Length - 1 - i));
            }
        }
        return result;
    }
    static string ConvertToOutputSystem(int decimalNumber,int outputSystem)
    {
        string answer = string.Empty;
        do
        {
            if (decimalNumber % outputSystem < 10)
            {
                answer += (decimalNumber % outputSystem).ToString();
            }
            else
            {
                answer += ((char)(decimalNumber % outputSystem+55)).ToString();
            }
            decimalNumber /= outputSystem;
        } while (decimalNumber > 0);
        return answer;
    }
    static void Main()
    {
        int inputSystem = int.Parse(Console.ReadLine());
        int outputSystem = int.Parse(Console.ReadLine());
        string inputNumber = Console.ReadLine();
        int decimalAnswer = 0;
        string finalAnswer = string.Empty;

        decimalAnswer = ConvertToDecimal(inputNumber, inputSystem);
        finalAnswer=ConvertToOutputSystem(decimalAnswer,outputSystem);
        PrintResult(finalAnswer);
    }
}