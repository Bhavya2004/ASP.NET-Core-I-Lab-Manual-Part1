/* Write a program using method overloading by changing datatype of 
arguments to perform addition of two integer numbers and two float 
numbers. */

using System;

public class OverloadingAddition
{
    public static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        float num3 = 1.5f;
        float num4 = 2.5f;

        int intResult = Add(num1, num2);
        Console.WriteLine("Addition of two integers: " + intResult);

        float floatResult = Add(num3, num4);
        Console.WriteLine("Addition of two floats: " + floatResult);
    }

     static int Add(int a, int b)
    {
        return a + b;
    }

     static float Add(float a, float b)
    {
        return a + b;
    }
}
