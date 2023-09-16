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
                    Consol.WriteLine("It might be a bit breezy take a coat") //if number is >= 15 and <= 20 display this message
                }
                else
                {
                    Console.WriteLine("It's freezing outside dress for the snow") // if number is anything else display this message
                }
        }
}