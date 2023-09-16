using System;

    public class Program
{
	    public void Main()
	    {   
		
		    Console.WriteLine("Enter the current temperature in celsius"); // Enter temp in Celcius
		    Compare(26,30, 25);
		
	    }

			
public void Compare (int value, int value2, int value3)
	{
	if(value <= value2 && value >= value3)
		Console.WriteLine("Enjoy the Pleasant Weather");
	}
}