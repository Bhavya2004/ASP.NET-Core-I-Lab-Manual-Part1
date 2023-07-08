/* Write a program to get two numbers from user and print those two 
numbers */

using System;

class PrintNumbers
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First number: " + number1);
        Console.WriteLine("Second number: " + number2);
    }
}
