/* Program to implement the following multiple inheritance using interface
Interface : Gross
Method- Gross_sal()
Class : Salary
Data Members - HRA, TA, DA
Methods - Disp_sal()
Class: Employee
Data Members - Name
Methods - basic_sal() */

using System;

interface Gross
{
    void Gross_sal();
}

interface Employee
{
    void basic_sal();
}

class Salary : Gross
{
    protected double HRA;
    protected double TA;
    protected double DA;

    public void Gross_sal()
    {
        double grossSalary = HRA + TA + DA;
        Console.WriteLine("Gross Salary: Rs" + grossSalary);
    }

    public void Disp_sal()
    {
        Console.WriteLine("Salary Details:");
        Console.WriteLine("HRA: Rs" + HRA);
        Console.WriteLine("TA: Rs" + TA);
        Console.WriteLine("DA: Rs" + DA);
    }
}

class Program : Salary, Employee
{
    public static void Main(String[] args)
    {
        Program p = new Program();
        p.basic_sal();
        p.HRA = 1000;
        p.TA = 500;
        p.DA = 800;
        p.Disp_sal();
        p.Gross_sal();
    }

    public void basic_sal()
    {
        Console.Write("Enter Employee Name: ");
        string Name = Console.ReadLine();
        Console.WriteLine("Basic Salary: $5000");
    }
}
