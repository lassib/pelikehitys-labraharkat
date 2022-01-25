using System;
using System.Collections.Generic;
using System.Text;

namespace _10_triangle2
{
    public class Triangle
    {
        public void drawStar(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int o = 1; o <= i; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Triangle of size " + count + " created");
        }

        public void drawCristmasTree(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                for (int o = 1; o <= i; o++)
                {

                }
                for (int o = 1; o <= i; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cristmasttree of size " + height + " created");
        }
    }
}