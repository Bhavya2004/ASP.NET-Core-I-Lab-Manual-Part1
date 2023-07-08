//. Write a program to return the factorial from the method using delegate.

using System;
delegate int FactorialDelegate(int n);

class Factorial
{
    static int n;
    public static int CalculateFactorial(int n)
    {
        int fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    public static void Main(String[] args)
    {
        //create delegate intance
        FactorialDelegate obj = new FactorialDelegate(CalculateFactorial);

        Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());

        //calling method using delegate object
        int ans = obj(n);
        Console.WriteLine("Factorial = " + ans);


    }
}
