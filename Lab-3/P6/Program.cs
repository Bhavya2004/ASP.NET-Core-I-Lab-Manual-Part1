/* Write a program to Define a class Distance have data members dist1, dist2,
dist3. Initialize the two data members using constructor and store their 
addition in third data member using function and display addition. */

using System;

class Distance
{
     int dist1;
     int dist2;
     int dist3;

    public Distance(int distance1, int distance2)
    {
        dist1 = distance1;
        dist2 = distance2;
    }

    public void CalculateAddition()
    {
        dist3 = dist1 + dist2;
    }

    public void DisplayAddition()
    {
        Console.WriteLine("Addition: " + dist3);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Distance d = new Distance(10, 20);

        d.CalculateAddition();

        d.DisplayAddition();
    }
}
