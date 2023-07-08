/* Write a program to calculate Celsius to Fahrenheit and vice-versa using 
function. */

using System;

class TemperatureConverter
{
    static void Main(String[] args)
    {
        Console.WriteLine("1. Convert Celsius to Fahrenheit");
        Console.WriteLine("2. Convert Fahrenheit to Celsius");
        int opt = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the temperature:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (opt == 1)
        {
            double temp = CelsiusToFahrenheit(temperature);
            Console.WriteLine("Temperature in Fahrenheit: " + temp);
        }
        else if (opt == 2)
        {
            double temp1 = FahrenheitToCelsius(temperature);
            Console.WriteLine("Temperature in Celsius: " + temp1);
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
