/*Create a class Furniture with material, price as data members. Create 
another class Table with Height, surface_area as data members. Write a
program to implement single inheritance.*/

using System;

class Furniture
{
    string material;
    double price;

    public Furniture(string material, double price)
    {
        this.material = material;
        this.price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Material: " + material);
        Console.WriteLine("Price: Rs" + price);
    }
}

class Table : Furniture
{
    double height;
    double surfaceArea;

    public Table(string material, double price, double height, double surfaceArea)
        : base(material, price)
    {
        this.height = height;
        this.surfaceArea = surfaceArea;
    }

    public void DisplayTableDetails()
    {
        Console.WriteLine("--- Table Details ---");
        DisplayDetails();
        Console.WriteLine("Height: " + height + " cm");
        Console.WriteLine("Surface Area: " + surfaceArea + " sq. cm");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Table t = new Table("Wood", 200.0, 75.0, 1200.0);
        t.DisplayTableDetails();
    }
}

