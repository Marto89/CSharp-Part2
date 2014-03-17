//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class XORCharactersEncode
{
    static void Main()
    {
        string cipher = Console.ReadLine();
        string text = Console.ReadLine();

        StringBuilder answer = new StringBuilder();
        //ab ab a
        //Na ko v
        for (int i = 0; i < text.Length; i++)
        {
            answer.AppendFormat(@"\u{0:x4}",text[i]^cipher[i%cipher.Length]);
        }
        Console.WriteLine(answer);
    }
}