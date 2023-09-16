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



//Enhancing test code asking subject wtih switches
    
using System;

    public class Program
{
	    public void Main()
	    {   

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