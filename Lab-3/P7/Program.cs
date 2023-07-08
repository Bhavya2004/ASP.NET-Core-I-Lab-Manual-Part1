//Write a program to calculate area of a Rectangle using constructor.

using System;

class AreaOfRectangle
{
    double length;
    double breadth;

    AreaOfRectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    double CalculateArea()
    {
        return length * breadth;
    }

    public static void Main(string[] args)
    {
        double length, breadth;

        Console.WriteLine("Enter the length of the rectangle:");
        length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the breadth of the rectangle:");
        breadth = Convert.ToDouble(Console.ReadLine());

        AreaOfRectangle rectangle = new AreaOfRectangle(length, breadth);
        double area = rectangle.CalculateArea();

        Console.WriteLine("Area of Rectangle = " + area);
    }
}
