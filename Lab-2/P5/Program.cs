//Write a program to print Fibonacci series.

using System;

class FibonacciSeries
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci series:");
        int num = Convert.ToInt32(Console.ReadLine());

        int firstTerm = 0;
        int secondTerm = 1;

        Console.Write("Fibonacci Series: " + firstTerm + " " + secondTerm);

        for (int i = 3; i <= num; i++)
        {
            int nextTerm = firstTerm + secondTerm;
            Console.Write(" " + nextTerm);

            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }

        Console.WriteLine();
    }
}
