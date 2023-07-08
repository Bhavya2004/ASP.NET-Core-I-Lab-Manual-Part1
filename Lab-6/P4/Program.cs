/* Create a Queue which takes integer values and perform following 
operations: 
a.Enqueue() - Adds an item into the queue.
b. Dequeuer() -Returns an item from the beginning of the queue and 
 removes it from the queue.
c. Peek() -Returns an first item from the queue without removing it.
d. Contains() -Checks whether an item is in the queue or not
e. Clear() -Removes all the items from the queue */

using System;
using System.Collections.Generic;

public class QueueDemo
{
    public static void Main()
    {
        Queue<int> q = new Queue<int>();

        // Enqueue new items into the queue
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        // Print the queue
        Console.WriteLine("Queue:");
        PrintQueue(q);

        // Dequeue an item from the queue
        int dequeuedItem = q.Dequeue();
        Console.WriteLine("Dequeued item: " + dequeuedItem);
        PrintQueue(q);

        // Peek at the first item in the queue
        int firstItem = q.Peek();
        Console.WriteLine("First item: " + firstItem);

        // Check if an item exists in the queue
        int itemToCheck = 20;
        bool containsItem = q.Contains(itemToCheck);
        Console.WriteLine("Queue contains item " + itemToCheck + ": " + containsItem);

        // Clear the queue
        q.Clear();
        Console.WriteLine("Queue cleared.");
        PrintQueue(q);
    }

    public static void PrintQueue(Queue<int> queue)
    {
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
