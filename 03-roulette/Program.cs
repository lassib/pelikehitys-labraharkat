using System;

namespace _03_roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Roulette player");
            Roulette theRoulette = new Roulette();
            Player player = new Player(theRoulette);
            player.Play();
        }
    }
}
