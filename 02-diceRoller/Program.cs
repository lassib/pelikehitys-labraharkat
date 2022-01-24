using System;

namespace _02_diceRoller
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
