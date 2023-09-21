using System;

  public class Program
  {
    public static void Main()
    {
		 Console.WriteLine("Enter a positive number into the pyramid");
     int numRows = int.Parse(Console.ReadLine());
			 
      for (int i = 1; i <= numRows; i++) //displays the number you inputed
        Console.WriteLine(i); // Prints out numbers and adds row
    }
  }
