using System;

namespace _10_triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle theTriangle = new Triangle();
            bool state = true;
            while(state){
                Console.WriteLine("Enter size of triangle in integer: ");
                string a;
                a = Console.ReadLine();
                int b;
                bool ok = Int32.TryParse(a, out b);
                if (ok)
                {
                    state = false;
                    theTriangle.drawStar(b);
                    theTriangle.drawCristmasTree(b);
                }
                else
                {
                    Console.WriteLine("You did not enter an integer");
                }
            }

        }
    }
}