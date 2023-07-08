/*Write a program to create a class Staff having data members as Name,
Department, Designation, Experience & Salary. Accept this data for 5
different staffs and display only names & salary of those staff who are 
HOD*/
using System;

class Staff
{
     public String Name;
     public String Department;
     public String Designation;
     public int Experience;
     public double Salary;

    public void AcceptStaffDetails()
    {
        Console.WriteLine("Enter staff details:");
        Console.Write("Name: ");
        Name = Console.ReadLine();
        Console.Write("Department: ");
        Department = Console.ReadLine();
        Console.Write("Designation: ");
        Designation = Console.ReadLine();
        Console.Write("Experience : ");
        Experience = Convert.ToInt32(Console.ReadLine());
        Console.Write("Salary: ");
        Salary = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayStaffDetails()
    {
        Console.WriteLine("\nStaff Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Designation: " + Designation);
        Console.WriteLine("Experience: " + Experience + " years");
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        // Create an array of Staff objects
        Staff[] s = new Staff[5];

        // Accept staff details
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = new Staff();
            s[i].AcceptStaffDetails();
        }

        // Display names and salaries of HODs
        Console.WriteLine("\nHODs:");
        foreach (Staff staffMember in s)
        {
            if (staffMember.Designation == "HOD")
            {
                Console.WriteLine("Name: " + staffMember.Name);
                Console.WriteLine("Salary: " + staffMember.Salary);
                Console.WriteLine();
            }
        }
    }
}
