

using System;

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the current temperature in celsius"); // Asks to enter the temperature in celsius

            int temp = 30; //Sets the temperature 
      if (temp > 30) 
      {
        Console.WriteLine("It's hot outside remember to stay hydrated"); //will display this line if greater than 30
      } 
      else if (temp < 30) 
      {
        Console.WriteLine("Enjoy the Pleasant weather outside"); //will dispaly this line if less than 30
      } 
      else 
      {
        Console.WriteLine("Perfect Weather"); // displays if they put in 30 exactly 
      }
            
        }
    }

  

