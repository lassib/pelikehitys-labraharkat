using System;
using System.Collections.Generic;
using System.Text;

namespace _08_dice
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
