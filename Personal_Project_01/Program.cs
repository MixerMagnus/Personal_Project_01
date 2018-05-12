using System;
using System.Threading;


// Goals of this project
// 1. Ask the user if they want to play
//     dev a system for yes or no
// 2. Have user guess the number
//     if too low or too high, clarify and start again
// 3. if correct number is chosen, state so and end

namespace Number_guessing_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
		Console.WriteLine("Would you like to play a game? (Y/N)");
		string input = Console.ReadLine();
			if ( input.ToLower() == "y")
			{
				//introdicing game rules
            Console.WriteLine("I'm thinking of a number between 1 and 9...");
            Thread.Sleep(2000);
            Console.WriteLine("Care to have a guess?");
			}
		else
			{
			Thread.Sleep(1000);
			Console.WriteLine("I understand...Goodbye...");
			}
            


        }
    }
}
