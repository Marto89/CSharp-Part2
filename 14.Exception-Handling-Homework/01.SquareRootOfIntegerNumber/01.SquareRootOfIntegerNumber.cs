//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SquareRootOfIntegerNumber
{
    static void Main()
    {
        try
        {
            uint number = uint.Parse(Console.ReadLine());

            double answer;
            Console.WriteLine("{0:F2}",answer = Math.Sqrt(number));
        }
        catch(OverflowException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}