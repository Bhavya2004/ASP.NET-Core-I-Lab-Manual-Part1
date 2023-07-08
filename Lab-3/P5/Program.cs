/* Write a program to Define a class Salary which will contain member 
variable Basic, TA, DA, HRA. Write a program using Constructor with default
values for DA and HRA and calculate the salary of employee. */

using System;

class Salary
{
     double Basic;
     double TA;
     double DA;
     double HRA;

    // Constructor with default values for DA and HRA
    public Salary(double basic, double ta, double da = 0.15, double hra = 0.1)
    {
        Basic = basic;
        TA = ta;
        DA = da * Basic;
        HRA = hra * Basic;
    }

    // Calculate total salary
    public double CalculateSalary()
    {
        return Basic + TA + DA + HRA;
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Salary s = new Salary(50000, 5000);

        double totalSalary = s.CalculateSalary();
        Console.WriteLine("Total Salary: " + totalSalary);
    }
}
