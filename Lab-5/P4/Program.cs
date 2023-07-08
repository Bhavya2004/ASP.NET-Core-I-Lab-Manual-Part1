/*Create a class named RBI with calculateInterest() method.Create another 
classes HDFC, SBI, ICICI which overrides calculateInterest() method.*/

using System;

public class RBI
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Calculating interest as per RBI rules.");
    }
}

public class HDFC : RBI
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest as per HDFC rules.");
    }
}

public class SBI : RBI
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest as per SBI rules.");
    }
}

public class ICICI : RBI
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest as per ICICI rules.");
    }
}

public class Bank
{
    public static void Main()
    {
        RBI rbi = new RBI();
        rbi.CalculateInterest();

        HDFC hdfc = new HDFC();
        hdfc.CalculateInterest();

        SBI sbi = new SBI();
        sbi.CalculateInterest();

        ICICI icici = new ICICI();
        icici.CalculateInterest();
    }
}
