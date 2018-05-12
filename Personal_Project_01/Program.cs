using System;
using System.Threading;


// Goals of this project
// 1. Ask the user if they want to play (done)
//     dev a system for yes or no (Done)
// 2. Have user guess the number ()
//     if too low or too high, clarify and start again ()
// 3. if correct number is chosen, state so and end ()

namespace Number_guessing_game
{
    class MainClass
    {

		public static void Main(string[] args)
        {

		Console.WriteLine("Would you like to play a game? (Y/N)");
		string input = Console.ReadLine();
            //Assigning a random number for the game
            //(Needed out of the main function to avoid the number changing every wrong answer.
			Random NumMaker = new Random();
			int randomNumber = NumMaker.Next(8) + 1;
			if (input.ToLower() == "y")
			{
				//Calling the function for the game
				StartGame();

				///Next line tests the RNG to make sure it works.
				///Console.WriteLine(randomNumber);
				int uinput = 0;
				uinput = Convert.ToInt32(Console.ReadLine());
				while (uinput != randomNumber)
				{
					if (uinput < randomNumber)
					{
						Console.WriteLine("That's a bit too low.. Try again!");
						return StartGame;
					}
					if (uinput > randomNumber)
					{
						Console.WriteLine("That's too high...Give it another shot!");
						return StartGame;
					}
				}
				if (uinput == randomNumber)
				{
					Console.WriteLine("That's right! The number was ", randomNumber);
				}
			}
			else
			{
				Thread.Sleep(1000);
                Console.WriteLine("I understand...Goodbye...");
			}
          

		    }
		static void StartGame()
        {
            //introdicing game rules
            Console.WriteLine("I'm thinking of a number between 1 and 9...");
            Thread.Sleep(1500);
            Console.WriteLine("Take a guess and type your number.");
        }
        }

	}