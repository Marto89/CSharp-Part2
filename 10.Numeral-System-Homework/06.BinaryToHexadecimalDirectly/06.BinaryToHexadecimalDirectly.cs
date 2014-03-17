//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimalDirectly
{
    static void Main()
    {
        string input = Console.ReadLine();

        int length = input.Length;
        if(input.Length%4!=0)
        {
            length += (4 - input.Length % 4);
        }
        input = input.PadLeft(length, '0');

        string output = string.Empty;
        for (int i = 0; i < input.Length-3; i+=4)
        {
            string currentValue = string.Empty;
            for (int j = i; j < i+4; j++)
            {
                currentValue+=input[j];
            }
            switch (currentValue)
            {
                case"0000":
                    output += 0;
                    break;
                case "0001":
                    output += 1;
                    break;
                case "0010":
                    output += 2;
                    break;
                case "0011":
                    output += 3;
                    break;
                case "0100":
                    output += 4;
                    break;
                case "0101":
                    output += 5;
                    break;
                case "0110":
                    output += 6;
                    break;
                case "0111":
                    output += 7;
                    break;
                case "1000":
                    output += 8;
                    break;
                case "1001":
                    output += 9;
                    break;
                case "1010":
                    output += "A";
                    break;
                case "1011":
                    output += "B";
                    break;
                case "1100":
                    output += "C";
                    break;
                case "1101":
                    output += "D";
                    break;
                case "1110":
                    output += "E";
                    break;
                case "1111":
                    output += "F";
                    break;                  
                default:
                    output = "Error";
                    break;
            }
        }
        Console.WriteLine(output);
    }
}