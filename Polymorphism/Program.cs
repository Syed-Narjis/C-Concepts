//Implementation of Polymorphism through method overriding;
using System;
public class Employee                          //Base class
{
    public String FName ="FName";
    public String LName = "LName";

    public virtual void PrintFullName()          //Virtual method indicating it can override
    {
        Console.WriteLine(FName+ " "+LName);
    }
}
public class FullTimeEmployee : Employee          //Inheriting Employee class into FullTimeEmployee;
{
    public override void PrintFullName()          //Overriding PrintFullName();
    {
        Console.WriteLine(FName+ " "+LName +" -FullTime Employee");
    }
}
public class PartTimeEmployee : Employee                //Inheriting Employee class into PartTimeEmployee;
{
    public override void PrintFullName()                   //Overriding PrintFullName();
    {
        Console.WriteLine(FName + " " + LName + " -Part Time Employee");
    }
}

public class TemporaryEmployee : Employee                   //Inheriting Employee class into TemporaryEmployee;
{
{
    public override  void PrintFullName()                    //Overriding PrintFullName();
    {
        Console.WriteLine(FName + " " + LName + " -Temporary  Employee");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Employee[] emp = new Employee[4];                 //Array of Employee Obj;
        emp[0] = new Employee();
        emp[1] = new PartTimeEmployee();
        emp[2] = new FullTimeEmployee();
        emp[3] = new TemporaryEmployee();

        foreach (Employee e in emp)                          //For is use to itterate the array
        {
            e.PrintFullName();                                //Calling method;
        }

    }
}