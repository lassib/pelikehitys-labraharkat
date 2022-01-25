using System;

namespace _08_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dice Roller");
            Dice theDice = new Dice();
            Player player = new Player(theDice);
            player.Play();
        }
    }
}
