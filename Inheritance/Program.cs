// Implementation of Inheritance
using System;
public class Employee                                   //Defining Base Class
{
   public string FName;
    public String LName;
    public String Email;
     
    public void PrintFullName()                             //Declaring and defining method in base class;
    {
        Console.WriteLine(FName +  " " + LName);
    }

}

public class FullTimeEmployee : Employee                    //Inheriting Employee class to child class FullTimeEmployee;
    {
   public float yearlySalary;
    }

public class PartTimeEmployee : Employee                        //Inheriting Employee class to child class PartTimeEmployee;
{
   public float hourlyRate;
}
public class Program
{
    public static void Main(string[] args)
    {
        FullTimeEmployee FT = new FullTimeEmployee();           //obj of Class FullTimeEmployee;
        FT.FName = "Full";
        FT.LName = "Time";
        FT.yearlySalary = 500000;
        FT.PrintFullName();                                      //Accessing method of base class

        PartTimeEmployee PT = new PartTimeEmployee();                //obj of Class PartTimeEmployee;
        PT.FName = "Part";
        PT.LName = "Time";
        PT.hourlyRate = 500;
        PT.PrintFullName();                                          //Accessing method of base class

    }
    

}
