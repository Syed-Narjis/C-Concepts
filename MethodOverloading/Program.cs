//Implementation of Method Overloading
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        //Add method
        Add(4, 5);
        //Add Overloading method
        Add(6, 7,10);                           
    }
    //AddMethod with 2 parameters;
    public static void Add(int Fn,int Sn)                 
    {
        
        Console.WriteLine("Sum of numbers  {0} , {1} is {2} ", Fn,Sn, Fn + Sn);
        }

    //AddMethod with 3 parameters
    public static void Add(int Fn, int Sn, int tn)              
    {
        Console.WriteLine("Sum of numbers  {0} , {1} , {2} is {3} ",Fn,Sn,tn, Fn + Sn+tn);
    }


}
