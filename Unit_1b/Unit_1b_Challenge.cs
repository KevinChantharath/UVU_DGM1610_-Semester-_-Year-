//Enhancing celcius code

using System;

    public class Program
{
	    public void Main()
	    {   
		
		    Console.WriteLine("Enter the current temperature in celsius"); // Enter temp in Celcius
                int temp = 25;
                
                if (temp >= 31)
                {
                    Console.WriteLine("Drink some water it's hot outside"); //if number is higher than 30 display this message
                }
                else if (temp >= 25 && temp <= 30)
                {
                    Console.WriteLine("Enjoy the pleasant weather outside"); //if number is >= 25 and <= 30 display this message
                }
                else if (temp >= 15 && temp <= 20)
                {
                    Consol.WriteLine("It might be a bit breezy take a coat"); //if number is >= 15 and <= 20 display this message
                }
                else
                {
                    Console.WriteLine("It's freezing outside dress for the snow"); // if number is anything else display this message
                }
        }
}

//Normal test code

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




//Enhancing test code asking subject wtih switches
    


        Console.WriteLine("Enter your favorite subject 1 = math 2 = science 3 = english")// tell them to enter subject using numbers

      int subject = 1;
      switch (subject) 
      {
        case 1:
          Console.WriteLine("Math is fun when you understand it"); //display if they enter 1 for math
          break;
        case 2:
          Console.WriteLine("Science is very interesting and fun"); //display if they enter 2 for sceience
          break;
        case 3:
          Console.WriteLine("You can do beatiful things with words"); //display if they enter 3 for english
          break;
      }
        }
    }