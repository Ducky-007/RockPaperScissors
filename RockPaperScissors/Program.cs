// creates app for Rock Paper Scissors game
using System;

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
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            // Game logic goes here
        }
    }
}