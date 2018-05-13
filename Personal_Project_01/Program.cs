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
            //Calling needed parts
			Random random = new Random();
			int randomNumber = random.Next(1, 11);
			int guess;
			int numberOfGuesses = 0;
			bool gameover = false;

            //Game rules listed
			Console.WriteLine("I'm thinking of a number between 1 and 10...");
			Thread.Sleep(500);
			Console.WriteLine("Type your guess");

            //main game loop
			while (gameover == false)
			{
				guess = Convert.ToInt32(Console.ReadLine());
				numberOfGuesses++;

				//User is correct or cheats
				if (guess == randomNumber)
				{
					Thread.Sleep(500);
					Console.WriteLine("That's right! The number was {0} And you got it in {1} tries!!", guess, numberOfGuesses);
					gameover = true;
				}

				else if (guess == 1337)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("We got a LEET H4X3R HERE");
                    Thread.Sleep(1500);
                    Console.WriteLine("I GUESS YOU WIN OR WHATEVER");
                    Thread.Sleep(2000);
                    Console.WriteLine("Congrats...");
					Thread.Sleep(2500);
                    Console.WriteLine("...PRICK...");
                    gameover = true;
                }

				//Guess is too High
				else if (guess > randomNumber)
				{
					Thread.Sleep(500);
					Console.WriteLine("That's too high. Give it another go.");
				}

                //Guess is too low
				else if (guess < randomNumber)
                {
					Thread.Sleep(500);
					Console.WriteLine("That's too low my dude. Try again.");
                }


			}

			Console.WriteLine("G A M E  O V E R");
			Console.ReadLine();

		}
       
	}

}