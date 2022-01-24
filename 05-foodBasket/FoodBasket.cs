using System;
using System.Collections.Generic;
using System.Text;

namespace _05_foodBasket
{
    public class FoodBasket
    {
        public void Price()
        {
            double basketPrice = 100;
            Console.WriteLine("Food basket price for month 1 = 100");

            for (int i = 2; i < 13; i++)
            {
                basketPrice = basketPrice * 1.015;
                basketPrice = Math.Round(basketPrice, 2);
                Console.WriteLine("Food basket price for month " + i + " = " + basketPrice);
            }

        }
    }
}
