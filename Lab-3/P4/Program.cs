/* Write a program with following specifications: 
Class Name: Student
Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
Get Students Details using constructor and DisplayStudentDetails() using
member function. */

using System;

class Student
{
    int Enrollment_No;
    string Student_Name;
    int Semester;
    double CPI;
    double SPI;

    // Constructor to get student details
    public Student(int enrollmentNo, string studentName, int semester, double cpi, double spi)
    {
        Enrollment_No = enrollmentNo;
        Student_Name = studentName;
        Semester = semester;
        CPI = cpi;
        SPI = spi;
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Enrollment No: " + Enrollment_No);
        Console.WriteLine("Student Name: " + Student_Name);
        Console.WriteLine("Semester: " + Semester);
        Console.WriteLine("CPI: " + CPI);
        Console.WriteLine("SPI: " + SPI);
    }
}

class Program
{
   public static void Main(String[] args)
    {
        // Get student details using constructor
        Student student = new Student(2101010, "Bhavya", 5, 9.4, 8.88);

        // Display student details
        student.DisplayStudentDetails();
    }
}
