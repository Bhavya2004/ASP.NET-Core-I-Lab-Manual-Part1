using System;

public class DivideByZero
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter the dividend: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero exception occurred: ");
        }
    }
}
