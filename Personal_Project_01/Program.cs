using System;
using System.Threading;


// Goals of this project
// 1. Ask the user if they want to play ()
//     dev a system for yes or no ()
// 2. Have user guess the number ()
//     if too low or too high, clarify and start again ()
// 3. if correct number is chosen, state so and end ()

namespace Number_guessing_game
{
	class MainClass
	{

		public static void Main(string[] args)
		{
            ///THIS IS THE GAME
			asktoplay();
			string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
				Thread.Sleep(100);
				Console.WriteLine("Let's begin..");
            }


			Thread.Sleep(500);

			startGame();

			gameLoop();

            ///End of game section
		}
       


        //Create a function list
        
        //Function 1, Ask to play a game
		static void asktoplay()
		{
			Console.WriteLine("Hello there...");
			Thread.Sleep(1000);
			Console.WriteLine("Would you like to press a game? (Y/N)");

		}

		//Function 2, Introduce Game rules
        static void startGame()
		{
			Console.WriteLine("I'm thinking of a number between 1 and 9...");
			Thread.Sleep(1500);
			Console.WriteLine("Take a guess. Type your answer.");

		}

        static void gameLoop()
		{
			Random Nummaker = new Random();
            int rannum = Nummaker.Next(8) + 1;
			int uguess = 0;
			uguess = Convert.ToInt32(Console.ReadLine());
			while (uguess != rannum)
			{
				if (uguess < rannum)
				{
					Console.WriteLine("That's a bit too low...Try again..");
					return;
				}

                if (uguess > rannum)
				{
					Console.WriteLine("That's too high. Give it another go!");
					return;
				}

				if (uguess == rannum)
				{
					Console.WriteLine("That's right! The number was {0} ", rannum);
					return;
				}
			}
		}
	}

}