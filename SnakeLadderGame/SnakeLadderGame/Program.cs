using System;

namespace SnakeLadderGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");

            // Create object of class SnakeLadder..
            SnakeLadder ObjGame= new SnakeLadder();

            // Calling method Start Game..
            ObjGame.StartGame();
            Console.ReadKey();
        }
    }
}
