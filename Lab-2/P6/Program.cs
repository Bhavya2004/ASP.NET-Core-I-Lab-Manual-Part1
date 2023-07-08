/* Write a program that takes a number as input and displays its equivalent 
binary form. */

using System;

class DecimalToBinary
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        string binaryNumber = "";

        if (decimalNumber == 0)
        {
            binaryNumber = "0";
        }
        else
        {
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryNumber = remainder + binaryNumber;
                decimalNumber /= 2;
            }
        }

        Console.WriteLine("Binary form: " + binaryNumber);
    }
}
