/* Write a program to create a class named Candidate with ID, Name, Age,
Weight and Height as data members & also create a member functions like 
GetCandidateDetails() and DisplayCandidateDetails(). */

using System;

class Candidate
{
     int ID;
     string Name;
     int Age;
     double Weight;
     double Height;

    public void GetCandidateDetails()
    {
        Console.WriteLine("Enter candidate details:");
        Console.Write("ID: ");
        ID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        Name = Console.ReadLine();
        Console.Write("Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Weight (in kg): ");
        Weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height (in meters): ");
        Height = Convert.ToDouble(Console.ReadLine());
    }

  
    public void DisplayCandidateDetails()
    {
        Console.WriteLine("\nCandidate Details:");
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Weight: " + Weight + " kg");
        Console.WriteLine("Height: " + Height + " meters");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Candidate candidate = new Candidate();

        candidate.GetCandidateDetails();

        candidate.DisplayCandidateDetails();
    }
}
