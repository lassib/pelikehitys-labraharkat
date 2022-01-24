using System;
using System.Collections.Generic;
using System.Text;

namespace _02_diceRoller
{
    public class Player
    {
        private Dice myDice;
        public Player(Dice dice)
        {
            this.myDice = dice;
        }
        public void Play ()
        {
            // Roll dice
            Console.WriteLine("Player is playing");
            int result = myDice.Roll();
            Console.WriteLine("Player rolled: " + result);
        }
    }
}
