//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinaryDirectly
{
    static void Main()
    {
        string input = Console.ReadLine();

        string output = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case'0':
                    output+="0000";
                    break;
                case'1':
                    output += "0001";
                    break;
                case '2':
                    output += "0010";
                    break;
                case '3':
                    output += "0011";
                    break;
                case '4':
                    output += "0100";
                    break;
                case '5':
                    output += "0101";
                    break;
                case '6':
                    output += "0110";
                    break;
                case '7':
                    output += "0111";
                    break;
                case '8':
                    output += "1000";
                    break;
                case '9':
                    output += "1001";
                    break;
                case 'A':
                    output += "1010";
                    break;
                case 'B':
                    output += "1011";
                    break;
                case 'C':
                    output += "1100";
                    break;
                case 'D':
                    output += "1101";
                    break;
                case 'E':
                    output += "1110";
                    break;
                case 'F':
                    output += "1111";
                    break;
                default:
                    output = "Error!";
                    break;
            }
        }
        Console.WriteLine(output);
    }
}