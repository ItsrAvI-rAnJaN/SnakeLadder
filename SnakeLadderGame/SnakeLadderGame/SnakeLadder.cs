using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeLadder
    {
       public  int Player_Postion=0;
       public const int NoPlay=0;
       public const int Ladder = 1;
       public const int Snake=2;
        Random random =new Random();
        
        // Method to define Player intial Start Position
        public void StartGame()
        {
            Console.WriteLine("The  Start Position of Player is {0}", Player_Postion);
            int DiceRoll = random.Next(1, 7);
            int Option=random.Next(0, 3);

            switch (Option)
            {
                case Ladder:
                    Player_Postion += DiceRoll;
                    break;
                case Snake:
                    Player_Postion -= DiceRoll;
                    break;
                default:
                    Player_Postion = Player_Postion;
                    break;
            }
            Console.WriteLine("Current Position of Player = {0}",Player_Postion);
        }

       

        

    }
}
