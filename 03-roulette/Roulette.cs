using System;
using System.Collections.Generic;
using System.Text;

namespace _03_roulette
{
    public class Roulette
    {
        private Random rnd = new Random();
        public int Spin()
        {
            int rNumber = rnd.Next(37);
            if(rNumber == 37)
            {
                rNumber = 0;
            }
            return rNumber;

        }
    }
}
