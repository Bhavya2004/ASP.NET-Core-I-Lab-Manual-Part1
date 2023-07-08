/* Create a List for StudentName and perform following operations:
a.Add() - To Add new student in list
b.Remove() - To Remove Student with specified index
c. RemoveRange() -To Remove student with specified range.
d. Clear() -To clear all the student from the list */


using System.Collections.Generic;

public class ListDemo
{
    public static void Main()
    {
        List<string> studentNames = new List<string>();

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
        if (indexToRemove >= 0 && indexToRemove < studentNames.Count)
        {
            studentNames.RemoveAt(indexToRemove);
            Console.WriteLine("Student at index {0} removed.", indexToRemove);
        }
        else
        {
            Console.WriteLine("Invalid index specified.");
        }
        PrintList(studentNames);

        // Remove students within a specified range
        int rangeIndex = 1;
        int rangeCount = 2;
        if (rangeIndex >= 0 && rangeIndex + rangeCount <= studentNames.Count)
        {
            studentNames.RemoveRange(rangeIndex, rangeCount);
            Console.WriteLine("Students removed within range [{0}, {1}].", rangeIndex, rangeIndex + rangeCount - 1);
        }
        else
        {
            Console.WriteLine("Invalid range specified.");
        }
        PrintList(studentNames);

        // Clear the list
        studentNames.Clear();
        Console.WriteLine("All students cleared from the list.");
        PrintList(studentNames);
    }

    public static void PrintList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
