﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeLadder
    {
        public int Player_Postion = 0;
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        Random random = new Random();

        // Method to define Player intial Start Position
        public void StartGame()
        {
            Console.WriteLine("The  Start Position of Player is {0}", Player_Postion);
            int DiceRoll;
            int Option;

            // Using While to Repeat till Player reaches the Winning Position 100
            while (Player_Postion < 100)
            {
                DiceRoll = random.Next(1, 7); // to get no b/w 1 to 6
                Console.WriteLine("Number Get in Die is : {0}",DiceRoll); 
                Option=random.Next(0, 3);// to get Ladder Snake or Noplay
                Console.WriteLine("Current options is : {0}",Option);
                if (Option == Ladder)
                {
                    if ((Player_Postion + DiceRoll) > 100)
                    {
                        Player_Postion = 100;

                    }
                    else
                    {
                        Player_Postion += DiceRoll;

                    }
                }
                else if (Option == Snake)
                {
                    if(Player_Postion <= DiceRoll)
                    {
                        Player_Postion = 0;

                    }
                    else
                    {
                        Player_Postion -= DiceRoll;
                    }
                }
                else
                {
                    Player_Postion = Player_Postion;
                }
                Console.WriteLine("Player Reaches at : {0}",Player_Postion);

            }
            /*
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
            Console.WriteLine("Current Position of Player = {0}", Player_Postion);*/
        }





    }
}