/* Create a Stack which takes integer values and perform following 
operations:
a.Push() - To Add new item in stack
b.Pop() - To Remove item from the stack
c. Peek() – To Return the top item from the stack.
d. Contains() -To Checks whether an item exists in the stack or not.
e. Clear() -To clear items from stack */

using System;
using System.Collections.Generic;

public class StackDemo
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        // Push new items onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Print the stack
        Console.WriteLine("Stack:");
        PrintStack(stack);

        // Pop an item from the stack
        int poppedItem = stack.Pop();
        Console.WriteLine("Popped item: " + poppedItem);
        PrintStack(stack);

        // Peek at the top item of the stack
        int topItem = stack.Peek();
        Console.WriteLine("Top item: " + topItem);

        // Check if an item exists in the stack
        bool containsItem = stack.Contains(20);
        Console.WriteLine("Stack contains item " + containsItem);

        // Clear the stack
        stack.Clear();
        Console.WriteLine("Stack cleared.");
        PrintStack(stack);
    }

    public static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
