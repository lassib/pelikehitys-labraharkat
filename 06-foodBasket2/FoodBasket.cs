using System;
using System.Collections.Generic;
using System.Text;

namespace _06_foodBasket2
{
    public class FoodBasket
    {
        public void Price()
        {
            bool alert = true;
            double basketPrice = 100;
            Console.WriteLine("Food basket price for month 1 = 100");

            for (int i = 2; i < 13; i++)
            {
                basketPrice = basketPrice * 1.015;
                basketPrice = Math.Round(basketPrice, 2);
                if (basketPrice > 105 && alert == true)
                {
                    Console.WriteLine("WARNING, the price goes over 105!");
                    alert = false;
                }
                Console.WriteLine("Food basket price for month " + i + " = " + basketPrice);
            }

        }
    }
}
