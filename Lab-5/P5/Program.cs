/* Create a class Hospital with HospitalDetails() method.Create another 
classes Apollo, Wockhardt, Gokul_Superspeciality which overrides 
HospitalDetails() method */

using System;

public class Hospital
{
    public virtual void HospitalDetails()
    {
        Console.WriteLine("Hospital details");
    }
}

public class Apollo : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Apollo Hospital details");
    }
}

public class Wockhardt : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Wockhardt Hospital details");
    }
}

public class Gokul_Superspeciality : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Gokul Superspeciality Hospital details");
    }
}

public class OverridingMethod
{
    public static void Main()
    {
        Hospital h = new Hospital();
        h.HospitalDetails();

        Apollo a = new Apollo();
        a.HospitalDetails();

        Wockhardt w = new Wockhardt();
        w.HospitalDetails();

        Gokul_Superspeciality g = new Gokul_Superspeciality();
        g.HospitalDetails();
    }
}
