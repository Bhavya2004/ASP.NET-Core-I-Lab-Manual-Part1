/* Write a programs to Find Area of Square, Rectangle and Circle using
Method Overloading. */

using System;

public class OverloadingMethods
{
    public static void Main()
    {
        int sideLength = 5;
        int length = 6;
        int width = 4;
        double radius = 3.5;

        double squareArea = CalculateArea(sideLength);
        Console.WriteLine("Area of square: " + squareArea);

        double rectangleArea = CalculateArea(length, width);
        Console.WriteLine("Area of rectangle: " + rectangleArea);

        double circleArea = CalculateArea(radius);
        Console.WriteLine("Area of circle: " + circleArea);
    }

    public static double CalculateArea(int sideLength)
    {
        return Math.Pow(sideLength, 2);
    }

    public static double CalculateArea(int length, int width)
    {
        return length * width;
    }

    public static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}
