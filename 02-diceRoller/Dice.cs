using System;
using System.Collections.Generic;
using System.Text;

namespace _02_diceRoller
{
    public class Dice
    {
        private Random rnd = new Random();
        public int Roll()
        {
            return rnd.Next(6) + 1;
        }
    }
}
