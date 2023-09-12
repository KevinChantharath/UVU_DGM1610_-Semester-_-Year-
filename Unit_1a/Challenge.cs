// Using int,string, and float variables dislpay name,age, and health

using System;

class Program
{
    static void Main()
    {
        // make's user enter name I think?
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        //age and health variables
        
        int age = 15;
        float health = 3.5f;
        
        //used operator to take away 2 health 
        health -=2.0f;

        // Display the name, age, and health
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Health: " + health);
        }
}

