﻿//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

class GenericMethods
{
    static T MinOfSet<T>(params T[] numArray)
    {
        dynamic min = numArray[0];
        for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i] < min)
            {
                min = numArray[i];
            }
        }
        return min;
    }
    static T MaxOfSet<T>(params T[] numArray)
    {
        dynamic max = numArray[0];
        for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i] > max)
            {
                max = numArray[i];
            }
        }
        return max;
    }
    static T AverageOfSet<T>(params T[] numArray)
    {
        dynamic sum = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum = sum + numArray[i];
        }
        return (sum / numArray.Length);
    }
    static T SumOfSet<T>(params T[] numArray)
    {
        dynamic sum = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum = sum + numArray[i];
        }
        return sum;
    }
    static T ProductOfSet<T>(params T[] numArray)
    {
        dynamic product = 1;
        for (int i = 0; i < numArray.Length; i++)
        {
            product = product * numArray[i];
        }
        return product;
    }
    static void Main()
    {
        Console.WriteLine("The minimum of set of ints is: {0}", MinOfSet(1, 2, 3, 4, -5, 6, 7));
        Console.WriteLine("The maximum of set of ints is: {0}", MaxOfSet(1, 2, 3, 4, -5, 6, 7));
        Console.WriteLine("The average of set of ints is: {0}", AverageOfSet(2, 3));
        Console.WriteLine("The sum of set of ints is: {0}", SumOfSet(1, 2, 3, 4, -5, 6, 7));
        Console.WriteLine("The product of set of ints is: {0}", ProductOfSet(1, 2, 3, 4, -5, 6, 7));
    }
}