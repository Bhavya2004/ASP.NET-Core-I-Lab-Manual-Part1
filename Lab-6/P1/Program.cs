/* Create an ArrayList for StudentName and perform following operations:
a.Add() - To Add new student in list
b.Remove() - To Remove Student with specified index
c. RemoveRange() -To Remove student with specified range.
d. Clear() -To clear all the student from the list */

using System.Collections;

public class ArrayListDemo
{
    public static void Main()
    {
        ArrayList studentNames = new ArrayList();

        // Add new students to the list
        studentNames.Add("A");
        studentNames.Add("B");
        studentNames.Add("C");
        studentNames.Add("D");

        // Print the initial list
        Console.WriteLine("Initial student list:");
        PrintList(studentNames);

        // Remove student at specified index
        int indexToRemove = 1;
        studentNames.RemoveAt(indexToRemove);
        Console.WriteLine("Student at index {0} removed.", indexToRemove);
        PrintList(studentNames);

        // Remove students within a specified range
        int rangeIndex = 1;
        int rangeCount = 2;
        studentNames.RemoveRange(rangeIndex, rangeCount);
        Console.WriteLine("Students removed within range [{0}, {1}].", rangeIndex, rangeIndex + rangeCount - 1);
        PrintList(studentNames);

        // Clear the list
        studentNames.Clear();
        Console.WriteLine("All students cleared from the list.");
        PrintList(studentNames);
    }

    public static void PrintList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
