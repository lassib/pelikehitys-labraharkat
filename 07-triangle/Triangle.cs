using System;
using System.Collections.Generic;
using System.Text;

namespace _07_triangle
{
    public class Triangle
    {
        public void drawStar(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int o=1;o<=i;o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Triangle of size " + count + " created");
        }

        public void drawChristmasTree(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                for(int o = 1; o <= height - i; o++)
                {
                    Console.Write(" ");
                }
                for (int o = 1; o <= i; o++)
                {
                    Console.Write("*");
                }
                for (int o = 1; o <= i - 1; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            if(height >= 4)
            {
                for (int i = 1; i <= height - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("***");
                Console.WriteLine("");
                for (int i = 1; i <= height - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("***");
                Console.WriteLine("");
            }
            else
            {
                for (int i = 1; i <= height - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
            Console.WriteLine("Christmas tree of size " + height + " created");
        }
    }
}