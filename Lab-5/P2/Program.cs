/* Write a program using method overloading by changing number of 
arguments to calculate area of square and rectangle. */

using System;

public class OverloadingArea
{
    public static void Main()
    {
        int side = 5;
        int length = 6;
        int width = 4;

        int squareArea = CalculateArea(side);
        Console.WriteLine("Area of square: " + squareArea);

        int rectangleArea = CalculateArea(length, width);
        Console.WriteLine("Area of rectangle: " + rectangleArea);
    }

     static int CalculateArea(int s)
    {
        return s * s;
    }

     static int CalculateArea(int length, int width)
    {
        return length * width;
    }
}
