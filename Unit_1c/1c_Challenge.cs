//Code for Random Number Generator

using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
        int randomNumber = random.Next(1, 11);
		int attempt = 0;
		
        Console.Write("Guess the number: ");
		int userGuess = int.Parse(Console.ReadLine());
		{
			for(;userGuess != randomNumber; attempt++)
			{
				if(userGuess<randomNumber)
				{
					Console.Write("Try guessing higher");
					int guess = int.Parse(Console.ReadLine());
					break;	
				}
				
				else if (userGuess>randomNumber)
				{
					Console.WriteLine("Try guessing lower");
					int guess = int.Parse(Console.ReadLine());
					break;						
				}
			}
			
			if (userGuess==randomNumber)
			{
				Console.WriteLine("You guessed the number!");
				
			}
		}
	}
}

            



