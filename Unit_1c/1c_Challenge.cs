//Code for Random Number Generator

using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random(); //generates random stuff
        int randomNumber = random.Next(1, 11);//generates random number from 1-10
		int attempt = 0;
		
        Console.Write("Guess the number you have 2 attempts: "); //display this quote
		int userGuess = int.Parse(Console.ReadLine());//gives user input
		{
			for(;userGuess != randomNumber; attempt++)
			{
				if(userGuess<randomNumber)
				{
					Console.Write("Try guessing higher"); //if number is less than generated number display this
					int guess = int.Parse(Console.ReadLine()); //gives extra attempt
					break;
				}
				
				else if (userGuess>randomNumber)
				{
					Console.WriteLine("Try guessing lower");//if number is greater than generated number display this
					int guess = int.Parse(Console.ReadLine()); // gives extra attempt
					break;						
				}
			}
			
			if (userGuess==randomNumber)
			{
				Console.WriteLine("You guessed the number!"); //display if number is guessed correctly
				
			}
		}
	}
}

            



