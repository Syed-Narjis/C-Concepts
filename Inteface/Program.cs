/// Implementaion of interface an multiple inheritance

using System;

//Declaring  Interface
interface IShape                                
{
    void Area(int l,int b);
    
}

//Declaring  Interface
interface IColor
{
    void Color(string c);
}
// Implementing Multiple Inheritance 
public class Rectangle : IShape ,IColor                   
{
    //Defining Area method of interface IShape;
    public void Area(int l,int b)                          
    {
        Console.WriteLine("Area of rectangle is : {0} ", l * b);
    }

    //Defining Color method of interface IColor;
    public void Color(string c)                                   
    { 
    Console.WriteLine("Rectangle is {0} in colour ",c);
    }

}


public class Program
{
    public static void Main(String[] args)
    {
        //Accepting input from Console
        Console.WriteLine("Enter Color for your rectange shape");
        string c = Console.ReadLine();
        Rectangle r = new Rectangle();
        // Invoking method of interface IShape;
        r.Area(10,5);
        // Invoking method of interface IColor;
        r.Color(c);                                     
    }
}











