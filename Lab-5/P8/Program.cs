/* Write a program to create a delegate calculator to demonstrate the
example of generic delegate. */

using System;

//create delegate
delegate void Calculator(double a, double b);
class CalculatorDemo
{

    public static void Add(double a, double b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    public static void Sub(double a, double b)
    {
        Console.WriteLine("Substraction = " + (a - b));
    }

    public static void Mul(double a, double b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    public static void Div(double a, double b)
    {
        Console.WriteLine("Division = " + (a / b));
    }

    public static void Main(string[] args)
    {

        //create objects of delegate
        Calculator add = new Calculator(Add);
        Calculator sub = new Calculator(Sub);
        Calculator mul = new Calculator(Mul);
        Calculator div = new Calculator(Div);

        Console.Write("Enter a : ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b : ");
        double b = double.Parse(Console.ReadLine());

        //call methods using delegate
        add(a, b);
        sub(a, b);
        mul(a, b);
        div(a, b);
    }

}
