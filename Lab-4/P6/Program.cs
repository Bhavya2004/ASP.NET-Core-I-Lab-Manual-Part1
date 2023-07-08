using System;

public interface IShape
{
    double Circle(double radius);
    double Triangle(double baseLength, double height);
    double Square(double side);
}

public class ShapeCalculator : IShape
{
    public double Circle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Triangle(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    public double Square(double side)
    {
        return Math.Pow(side, 2);
    }
}

public class Shape
{
    public static void Main()
    {
        ShapeCalculator s = new ShapeCalculator();

        double circleArea = s.Circle(5);
        Console.WriteLine("Area of Circle: " + circleArea);

        double triangleArea = s.Triangle(6, 8);
        Console.WriteLine("Area of Triangle: " + triangleArea);

        double squareArea = s.Square(4);
        Console.WriteLine("Area of Square: " + squareArea);
    }
}
