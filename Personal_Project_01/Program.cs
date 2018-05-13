using System;
using System.Threading;


// Goals of this project
// 1. Ask the user if they want to play ()
//     dev a system for yes or no ()
// 2. Have user guess the number (Done)
//     if too low or too high, clarify and start again (Done)
// 3. if correct number is chosen, state so and end (Done)

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

			//Asking player if they want to play.
			Console.WriteLine("Would you like to play a game? (Y|N)");


			//Game rules listed
			Console.WriteLine("I'm thinking of a number between 1 and 10...");
			Thread.Sleep(500);
			Console.WriteLine("Type your guess");

            //main game loop
			while (gameover == false)
			{
				guess = Convert.ToInt32(Console.ReadLine());
				numberOfGuesses++;
				int randomREP = random.Next(4);

				//User is correct
				if (guess == randomNumber)
				{
					Thread.Sleep(500);
					Console.WriteLine("That's right! The number was {0} And you got it in {1} tries!!", guess, numberOfGuesses);
					gameover = true;
				}

                //EASTER EGG
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
					switch(randomREP)
					{
						case 0:
							{
								Console.WriteLine("Too High my dude");
								break;
							}
						case 1:
                            {
                                Console.WriteLine("A bit up there");
                                break;
                            }
						case 2:
                            {
                                Console.WriteLine("Not quite. Try lower");
                                break;
                            }
						case 3:
                            {
								Console.WriteLine("Shooting for the stars I see.");
                                Thread.Sleep(5000);
                                Console.WriteLine("Try again");
                                break;
                            }
					}
				}

                //Guess is too low
				else if (guess < randomNumber)
                {
					Thread.Sleep(500);
					switch(randomREP)
					{
						case 0:
							{
								Console.WriteLine("Too low");
								break;
							}
						case 1:
                            {
								Console.WriteLine("Not quite...Try higher");
                                break;

                            }
						case 2:
                            {
								Console.WriteLine("A bit too low");
                                break;

                            }
						case 3:
                            {
								Console.WriteLine("Find anything digging that low?");                        
                                break;

                            }
					}
                }


			}

			Thread.Sleep(1000);
			Console.WriteLine("G A M E  O V E R");
			Console.ReadLine();

		}
       
	}

}