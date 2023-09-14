//celcius code

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
      else (temp < 30) 
      {
        Console.WriteLine("Enjoy the Pleasant weather outside"); //will dispaly this line if less than 30
      } 
            
        }
    }

  //grading code

  using System;
    
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your scores in"); // enter your score

            int number = 100;
            if (number >= 90) 
      {
        Console.WriteLine("Excellent Job You're Grade is A"); // display if equal to or higher than 90
      } 
      else if (number >= 80 && number <= 89) 
      {
      	Console.WriteLine("Great Job You're Grade is B"); // display if equal to or higher than 80-89
      }
      else if (number >= 70 && number <= 79)
      {
      	Console.WriteLine("Still ok You're Grade is C"); // display if equal to or higher than 70-79
      }
      else if (number >= 60 && number <= 69)
      {
      	Console.WriteLine("Needs work You're Grade is D"); // display if equal to or higher than 60-69
      }
      else
      {
      	Console.WriteLine("You need help You're Grade is F"); // display if less than 60 and everything else
      }


        }
    }

