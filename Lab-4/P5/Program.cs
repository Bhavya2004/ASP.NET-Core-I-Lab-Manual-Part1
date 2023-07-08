using System;

public interface Calculate
{
    int Addition(int a, int b);
    int Subtraction(int a, int b);
}

public class Result : Calculate
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }
}

public class InterfaceExample
{
    public static void Main()
    {
        Result result = new Result();

        int additionResult = result.Addition(5, 10);
        Console.WriteLine("Addition Result: " + additionResult);

        int subtractionResult = result.Subtraction(20, 8);
        Console.WriteLine("Subtraction Result: " + subtractionResult);
    }
}
