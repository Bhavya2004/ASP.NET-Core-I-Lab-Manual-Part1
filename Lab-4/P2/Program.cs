using System;

public class IndexOutOfRange
{
    public static void Main()
    {
        try
        {
            int[] numbers = new int[5];

            for (int i = 0; i <= 5; i++) //  IndexOutOfRangeException
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range exception occurred: " );
        }
        
    }
}
