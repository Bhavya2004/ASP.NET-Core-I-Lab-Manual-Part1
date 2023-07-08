/* Write a program to find out Simple Interest using function. (I = PRN / 100) */

using System;

class SimpleInterestCalculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the principal amount (P):");
        double P = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the interest rate (R):");
        double R = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time period in years (N):");
        double N = Convert.ToDouble(Console.ReadLine());

        double interest = CalculateSimpleInterest(P, R, N);
        Console.WriteLine("Simple Interest (I): " + interest);
    }

    static double CalculateSimpleInterest(double P, double R, double N)
    {
        return (P * R * N) / 100;
    }
}
