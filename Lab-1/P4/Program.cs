/* Write a program to calculate the size of the area in square-feet based on 
Specified length and width. */

using System;

class AreaCalculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the length (in feet):");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width (in feet):");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("The area is: " + area + " square feet");
    }
}
