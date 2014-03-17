//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class AreTheBracketsPutCorrectly
{
    static void Main()
    {
        string input= Console.ReadLine();

        int counter = 0;
        bool isCorrect = true;
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i]=='(')
            {
                counter++;
            }
            else if (input[i]==')')
            {
                counter--;
            }

            if(counter<0)
            {
                isCorrect = false;
                break;
            }
        }
        if(counter>0)
        {
            isCorrect = false;
        }
        Console.WriteLine(isCorrect);
    }
}