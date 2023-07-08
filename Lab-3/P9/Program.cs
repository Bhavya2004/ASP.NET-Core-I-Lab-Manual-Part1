/* Write a program for implementing single inheritance which creates one 
class Account_Details for getting account information and another class
Interest for calculating and displaying total interest from the data inserted
from account details. */

using System;

class Account_Details
{
    protected string accountNumber;
    protected double balance;
    protected double interestRate;

    public void GetAccountDetails()
    {
        Console.Write("Enter Account Number: ");
        accountNumber = Console.ReadLine();
        Console.Write("Enter Balance: ");
        balance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Interest Rate (%): ");
        interestRate = Convert.ToDouble(Console.ReadLine());
    }
}

class Interest : Account_Details
{
    public void CalculateInterest()
    {
        double totalInterest = balance * interestRate / 100;
        Console.WriteLine("Total Interest: Rs" + totalInterest);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Interest acc = new Interest();
        acc.GetAccountDetails();
        acc.CalculateInterest();
    }
}
