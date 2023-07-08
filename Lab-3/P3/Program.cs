/* Write a pogram to Create a class Bank_Account with Account_No, Email,
User_Name, Account_Type and Account_Balance as data members. Also 
create a Member function GetAccountDetails() &DisplayAccountDetails(). */

using System;

class Bank_Account
{
    int Account_No;
    string Email;
    string User_Name;
    string Account_Type;
    double Account_Balance;

    public void GetAccountDetails()
    {
        Console.WriteLine("Enter account details:");
        Console.Write("Account Number: ");
        Account_No = Convert.ToInt32(Console.ReadLine());
        Console.Write("Email: ");
        Email = Console.ReadLine();
        Console.Write("User Name: ");
        User_Name = Console.ReadLine();
        Console.Write("Account Type: ");
        Account_Type = Console.ReadLine();
        Console.Write("Account Balance: ");
        Account_Balance = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("\nAccount Details:");
        Console.WriteLine("Account Number: " + Account_No);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("User Name: " + User_Name);
        Console.WriteLine("Account Type: " + Account_Type);
        Console.WriteLine("Account Balance: " + Account_Balance);
    }
}

class Program
{
    public static void Main(String[] args)
    {
     
        Bank_Account account = new Bank_Account();

        account.GetAccountDetails();

        account.DisplayAccountDetails();
    }
}
