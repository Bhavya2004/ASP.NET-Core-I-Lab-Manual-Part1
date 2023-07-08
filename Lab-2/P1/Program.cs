/* Body Mass Index (BMI) is a measure of health on weight. It can be 
calculated by taking your weight in kilograms and dividing by the square of 
your height in meters. Write a program that prompts the user to enter a 
weight in pounds and height in inches and displays the BMI. 
(Note: -1 pound = 0.45359237 Kg and 1 inch = 0.0254 meters) */

using System;

class BMICalculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your weight in pounds:");
        double Pounds = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height in inches:");
        double Inches = Convert.ToDouble(Console.ReadLine());

        double Kg = Pounds * 0.45359237;
        double Meters = Inches * 0.0254;

        double bmi = Kg / (Meters * Meters);

        Console.WriteLine("Your BMI is: " + bmi);
    }
}
