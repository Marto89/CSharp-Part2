//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumberFromStartToEnd
{
    static int ReadNumber(int a,int b)
    {
        int numbers=0;
        try
        {
             numbers= int.Parse(Console.ReadLine());
            if((numbers<a) || (numbers>b))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex )
        {
            Console.WriteLine(ex.Message);
        }
        catch(OutOfMemoryException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return numbers;
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        int previousNumber=ReadNumber(start, end);
        int currentNumber;
        for (int i = 0; i < 9; i++)
        {
            try
            {

                currentNumber = ReadNumber(start, end);

                if (previousNumber >= currentNumber)
                {
                    throw new ArgumentOutOfRangeException();
                }
                previousNumber = currentNumber;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}