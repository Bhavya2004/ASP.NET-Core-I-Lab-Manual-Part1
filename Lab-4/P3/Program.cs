using System;

public class EvenException
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                throw new Exception("Number is not even.");
            }

            Console.WriteLine("The number is even.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
