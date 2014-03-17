//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class CalculateTheSurfaceOfATriangleProgram
{
    static double CalculateSurface(double side,double altitude)
    {
        double result = (side * altitude) / 2d;
        return result;
    }
    static double CalculateSurface(double sideA, double sideB,double sideC)
    {
        double perimiter = (sideA + sideB + sideC)/2;
        double result = Math.Sqrt(perimiter)*((perimiter-sideA)*(perimiter-sideB)*(perimiter-sideC));
        return result;
    }
    static double CalculateSurface(double sideA, double sideB,float angle)
    {
        double result = (sideA * sideB*Math.Sin(angle)) / 2d;
        return result;
    }
    static void Main()
    {
        Console.Write("Please, input your choise -a , b or c:");
        string input = Console.ReadLine();

        switch (input)
        {
            case"a":
                Console.Write("Enter a side:");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter an altitude:");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",CalculateSurface(side,altitude));
                return;
            case "b":
                Console.Write("Enter a side A:");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter a side B:");
                double sideB = double.Parse(Console.ReadLine()); 
                Console.Write("Enter a side C:");
                double sideC = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",CalculateSurface(sideA,sideB,sideC));
                return;
            case "c":
                Console.Write("Enter a first side:");
                double firstSide = double.Parse(Console.ReadLine());
                Console.Write("Enter a second side:");
                double secondSide = double.Parse(Console.ReadLine());
                Console.Write("Enter an angle:");
                float angle = float.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",CalculateSurface(firstSide,secondSide,angle));
                return;
        }
    }
}