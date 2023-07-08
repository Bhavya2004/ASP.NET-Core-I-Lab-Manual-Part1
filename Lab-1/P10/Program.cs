//Write a program to Swapping without using third variable.

using System;class NumberSwap{    public static void Main(String[] args)    {        Console.WriteLine("Enter the first number:");        int num1 = Convert.ToInt32(Console.ReadLine());        Console.WriteLine("Enter the second number:");        int num2 = Convert.ToInt32(Console.ReadLine());        Console.WriteLine("Before swapping:");        Console.WriteLine("First number: " + num1);        Console.WriteLine("Second number: " + num2);

        // Swapping without using a third variable
        num1 = num1 + num2;        num2 = num1 - num2;        num1 = num1 - num2;        Console.WriteLine("After swapping:");        Console.WriteLine("First number: " + num1);        Console.WriteLine("Second number: " + num2);    }}