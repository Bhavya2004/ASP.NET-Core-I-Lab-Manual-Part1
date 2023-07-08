/* Write a program to create a Simple Calculator for two numbers (Addition,
Multiplication, Subtraction, Division) [Also using if…else &Switch Case] */

using System;

class SimpleCalculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        int opr= Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (opr)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
