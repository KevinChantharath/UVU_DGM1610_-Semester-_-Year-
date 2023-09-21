using System;
					
public class Program
{
	public static void Main()
	{
        Console.Write("Enter a positive number into the pyramid");
        int numRows = int.Parse(Console.ReadLine()); // allows the user to input a number

        for (int i = 1; i <= numRows; i++) //inputs users number
        {
            for (int j = 1; j <= i; j++) // adds the rows
            {
                Console.Write(i); // writes out numbers
            }
            Console.WriteLine(); // writes out rows
        }
	}
}