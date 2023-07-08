// Write a program to find maximum numbers from given 3 numbers.

using System;

class MaximumNumber
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int maxNumber = (num1 >= num2 && num1 >= num3) ? num1 : (num2 >= num1 && num2 >= num3) ? num2 : num3;

        Console.WriteLine("Maximum number: " + maxNumber);
    }
}
