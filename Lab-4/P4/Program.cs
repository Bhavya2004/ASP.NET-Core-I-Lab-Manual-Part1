using System;

public abstract class Sum
{
    public abstract int SumOfTwo(int a, int b);
    public abstract int SumOfThree(int a, int b, int c);
}

public class Calculate : Sum
{
    public override int SumOfTwo(int a, int b)
    {
        return a + b;
    }

    public override int SumOfThree(int a, int b, int c)
    {
        return a + b + c;
    }
}

public class AbstractExample
{
    public static void Main()
    {
        Calculate c = new Calculate();

        int result1 = c.SumOfTwo(5, 10);
        Console.WriteLine("Sum of two numbers: " + result1);

        int result2 = c.SumOfThree(2, 4, 6);
        Console.WriteLine("Sum of three numbers: " + result2);
    }
}
