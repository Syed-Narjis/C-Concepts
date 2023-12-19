//Implementation of Method hiding
using System;
public class Employee
{
    public string FName;
    public String LName;
    public String Email;
    //Declaring and defining method in base class
    public void PrintFullName()                                                  
    {
        Console.WriteLine(FName + " " + LName);
    }

}
//Derived class from Employee
public class FullTimeEmployee : Employee              
{
   public void Etype()
    {
        Console.WriteLine("I am a Full time Employee");
    }
}
//Derived class of Employee
public class PartTimeEmployee : Employee                
{
    //hiding base class method using new 
    public new void PrintFullName()                   
    {
        //Calling base class method using base
        base.PrintFullName();                             
        Console.WriteLine(FName + " " + LName + " - Contractor" + "      //Using new keyword");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // creating Child class obj
        FullTimeEmployee FT = new FullTimeEmployee();              
        FT.FName = "Full";
        FT.LName = "Time";
        //Base class method will be called
        FT.PrintFullName();

        //Creating child class object
        PartTimeEmployee PT = new PartTimeEmployee();              
        PT.FName = "Part";
        PT.LName = "Time";
        //Child class method will be called
        PT.PrintFullName();                                        

    }


}
