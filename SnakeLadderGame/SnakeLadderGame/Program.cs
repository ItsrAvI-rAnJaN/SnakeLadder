using System;

namespace SnakeLadderGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t********Welcome to Snake Ladder Game********");
            SnakeLadder ObjGame= new SnakeLadder();
            ObjGame.StartGame();
            Console.ReadKey();
        }
    }
}
