// Write a program to calculate the nPr. (nPr = n! / (n - r)!)

using System;

class PermutationsCalculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the value of n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of r:");
        int r = Convert.ToInt32(Console.ReadLine());

        int nPr = CalculatePermutations(n, r);

        Console.WriteLine("nPr = " + nPr);
    }

    static int CalculatePermutations(int n, int r)
    {
        int numerator = 1;
        int denominator = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;
        }

        for (int i = 1; i <= (n - r); i++)
        {
            denominator *= i;
        }

        int nPr = numerator / denominator;

        return nPr;
    }
}
