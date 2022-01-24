using System;
using System.Collections.Generic;
using System.Text;

namespace _03_roulette
{
    public class Player
    {
        private Roulette myRoulette;
        public Player(Roulette roulette)
        {
            this.myRoulette = roulette;
        }
        public void Play()
        {
            // Spin roulette
            Console.WriteLine("Player is playing");
            int result = myRoulette.Spin();
            Console.WriteLine("Player spinned: " + result);
        }
    }
}
