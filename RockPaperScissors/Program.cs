// creates app for Rock Paper Scissors game
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.ReadKey();
        }
    }

    class Game
    {
        public void Start()
        {
            // declare variables
            int userWon = 0;
            int userLost = 0;
            int userDraw = 0;
            bool playAgain = true;
            string player;
            string computer;
            Random random = new Random();

            while (playAgain)
            {
                player = "";
                computer = "";

                // ask user to enter rock paper or scirssors
                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    System.Console.Write("Choose Rock, Paper or Scissors: ");
                    player = Console.ReadLine().ToLower();
                }

                // compare user choice with computer
                // if computer == 1
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissors";
                        break;
                }
                System.Console.WriteLine($"You choose: {player}"); // will output only when a correct choice is entered
                System.Console.WriteLine($"Computer choose: {computer}");

                // compare user to computer and declare outcome
                // interate result to count
                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("It's a draw!");
                            userDraw++;
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("You lose!");
                            userLost++;
                        }
                        else
                        {
                            System.Console.WriteLine("You win!");
                            userWon++;
                        }
                        break;

                    case "paper":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("You win!");
                            userWon++;
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("It's a draw!");
                            userDraw++;
                        }
                        else
                        {
                            System.Console.WriteLine("You lose!");
                            userLost++;
                        }
                        break;
                    case "scissors":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("You lose!");
                            userLost++;
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("You win!");
                            userWon++;
                        }
                        else
                        {
                            System.Console.WriteLine("It's a draw!");
                            userDraw++;
                        }
                        break;
                }

                System.Console.Write("Play again? (Y/N): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                {
                    playAgain = false;
                }
            }
            System.Console.WriteLine("Totals:");
            System.Console.WriteLine($"# of total Wins: {userWon}");
            System.Console.WriteLine($"# of total Loses: {userLost}");
            System.Console.WriteLine($"# of total Draws: {userDraw}");
            System.Console.WriteLine("Exiting game... Thanks for playing!");
        }
    }
}