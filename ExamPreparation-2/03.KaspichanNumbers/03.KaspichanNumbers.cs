using System;
using System.Text;

class KaspichanNumbers
{
    static string KaspichanNumber(ulong number)
    {
        if (number < 26)
        {
            return ((char)(number % 26 + 'A')).ToString();
        }
        else
        {
            StringBuilder result = new StringBuilder();
            result.Append((char)(number / 26 + 96));
            result.Append((char)(number % 26 + 'A'));
            return result.ToString();
        }      
    }
    static void Main()
    {

        ulong input = ulong.Parse(Console.ReadLine());
        StringBuilder answer = new StringBuilder();
        do
        {
            ulong currentNumber = input % 256;
            answer.Insert(0, KaspichanNumber(currentNumber));
            input = input / 256;
        } while (input != 0);

        Console.WriteLine(answer);
    }
}