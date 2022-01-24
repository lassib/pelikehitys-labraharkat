using System;
using System.Collections.Generic;
using System.Text;

namespace _04_loopTask
{
    public class LoopTester
    {
        public LoopTester()
        {

        }
        public void DoTheLoops()
        {
            Console.WriteLine("Look mom I'm looping!");
            int pc = 0, passengerLimit = 4;

            Console.WriteLine("while loop:");
            while (pc <= passengerLimit)
            {
                Console.WriteLine("Now I have " + pc + " passengers");
                pc = pc + 1;
            }


            // similar functionality using for loop:

            Console.WriteLine("for loop:");
            for (int pc2 = 0; pc2 <= passengerLimit; pc2++)
            {
                Console.WriteLine("Now I have " + pc2 + " passengers");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = " + i);
            }

            for (int i = 0; i < 8; i++)
            {
                if (i != 4)
                {
                    Console.WriteLine("i = " + i);
                }
            }

            bool stop = false;
            int count = 0;
            while (!stop)
            {
                if (count == 2)
                {
                    stop = true;
                }
                Console.WriteLine("count = " + count);
                count++;
            }
        }
    }
}
