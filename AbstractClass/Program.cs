// See https://aka.ms/new-console-template for more information

//Implementation of Abstract Clss;

using System;


public abstract class Animal        //Creating Abstract class
{
    public abstract void sound();   //Abstract method;
}

public class  Dog : Animal         //Inheriting from abstract method
{
    public override void sound()   //Implementing abstract method
    {
        Console.WriteLine("Dog Says:Bark Bark");

    }

}

public class Cat : Animal
{
    public override void sound()
    {
       Console.WriteLine("Cat says :Meow Meow");    
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Dog dog = new Dog();                 //Invoking by instance of a class Dog;
        dog.sound();

        Animal cat = new Cat();              //Invoking by reference var of abstarct class to derived class obj;
        cat.sound();
    }
}



    

