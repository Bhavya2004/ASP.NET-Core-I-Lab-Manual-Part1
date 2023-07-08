/* The marks obtained by a student in 5 different subjects are input through 
the keyboard. The student gets a grade as per the following rules:
a.Percentage above or equals to 60-first grade
b. Percentage between 50 to 59-second grade
c. Percentage between 40 and 49-Third grade
d. Percentage less than 40-poor Grade
Write a program to assign the grade obtained by the student */

using System;

class Grade
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the marks obtained in 5 subjects:");

        int totalMarks = 500;
        int obtainedMarks = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Subject {0}: ", i);
            int marks = Convert.ToInt32(Console.ReadLine());
            obtainedMarks += marks;
        }

        double percentage = (obtainedMarks / (double)totalMarks) * 100;

        Console.WriteLine("Percentage: " + percentage);

        if (percentage >= 60)
        {
            Console.WriteLine("First grade");
        }
        else if (percentage >= 50 && percentage < 60)
        {
            Console.WriteLine("Second grade");
        }
        else if (percentage >= 40 && percentage < 50)
        {
            Console.WriteLine("Third grade");
        }
        else
        {
            Console.WriteLine("Poor grade");
        }
    }
}
