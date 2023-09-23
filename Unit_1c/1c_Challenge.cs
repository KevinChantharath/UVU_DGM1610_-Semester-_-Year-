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

//Favorite Foods code

using System;

public class Program
{
    public static void Main()
    {
		string[] favoriteFoods = new string[3]; //has a array for 3 items

		for (int i = 0; i < 3; i++)  
        {
			Console.Write("Enter your 3 favorite foods: "); //displays message for favorite foods
			favoriteFoods[i] = Console.Readline(); //allows user inputs
		}   
			Console.WriteLine("These are your 3 favorite Foods?"); //displays message for food
			foreach (string food in favoriteFoods)
			{
				Console.WriteLine("I love " + food); //displays messasge for every food item
			}
	}
}





