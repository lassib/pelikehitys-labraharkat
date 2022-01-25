using System;
using System.Collections.Generic;
using System.Text;

namespace _08_dice
{
    public class Player
    {
        private Dice myDice;
        public Player(Dice dice)
        {
            this.myDice = dice;
        }
        public void Play()
        {
            Console.WriteLine("Player is playing");
            List<int> uniqueRollValues = new List<int>();
            int rollCounter = 0;

            while (uniqueRollValues.Count < 6)
            {
                int result = myDice.Roll(); //Rolls the dice
                
                if (!uniqueRollValues.Contains(result))
                {
                    uniqueRollValues.Add(result);
                }
                Console.WriteLine("Player rolled: " + result);
                rollCounter++; //Adds to counter

            }
            Console.WriteLine("Roll counter: " + rollCounter);
        }
    }
}
