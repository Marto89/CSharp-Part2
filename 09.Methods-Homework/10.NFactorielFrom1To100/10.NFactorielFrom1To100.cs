//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
class NFactorielFrom1To100
{
    static string Multiply(string number,int a)
    {
        int currentSum = 0;
        int currentSum2 = 0;
        string finalSum = string.Empty;
        //string answer = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            currentSum = 0;
            currentSum += int.Parse((a *(number[i]-48)).ToString());
            if(currentSum2!=0)
            {
                finalSum += (currentSum+ currentSum2);
            }
            currentSum2 = currentSum;
        }
        //answer = finalSum.ToString();
        return finalSum;
    }
    static string Transformation(int [] array)
    {
        string result = string.Empty;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            result += array[i];
        }
        return result;
    }
    public static int[] ToArray(string number)
    {
        int[] array = new int[number.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number[i] - 48;
        }
        return array;
    }
    public static string SumOfArray(string number1,string number2)
    {
        int[] firstArray=new int[number1.Length];
        int[] secondArray=new int [number2.Length];
        Array.Copy(firstArray, ToArray(number1), number1.Length);
        Array.Copy(secondArray, ToArray(number2), number2.Length);
       //Array.Reverse(firstArray);
       //Array.Reverse(secondArray);
        int maxLength = Math.Max(firstArray.Length, secondArray.Length);
        int[] realArray = new int[maxLength];
        int[] finalArray = new int[maxLength + 1];
        if (firstArray.Length > secondArray.Length)
        {
            Array.Copy(secondArray, realArray, secondArray.Length);
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(firstArray[i] + realArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
            if (counter == 1)
            {
                finalArray[finalArray.Length - 1] = 1;
            }
            number1 = Transformation(finalArray);
            return number1;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Array.Copy(firstArray, realArray, firstArray.Length);
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(realArray[i] + secondArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
            number1 = Transformation(finalArray);
            return number1;
        }
        else
        {
            int currentSum = 0;
            int counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                currentSum = (int)(firstArray[i] + secondArray[i]) + counter;
                counter = 0;
                if (currentSum <= 9)
                {
                    finalArray[i] = currentSum;
                }
                else if (currentSum > 9)
                {
                    finalArray[i] = currentSum % 10;
                    counter++;
                }
            }
        }
        number1 = Transformation(finalArray);
        return number1;
    }
    static void Main()
    {          
        int num=int.Parse(Console.ReadLine());

        string answer = "1";
        for (int i = 2; i < num; i++)
        {
            answer=Multiply(answer,i);
        }
        Console.WriteLine(answer);
    }
}
