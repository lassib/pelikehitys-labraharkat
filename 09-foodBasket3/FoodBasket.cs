using System;
using System.Collections.Generic;
using System.Text;

namespace _09_foodBasket3
{
    public class FoodBasket
    {
        public void Price()
        {
            List<string> monthNames = new List<string>();
            monthNames.Add("January");
            monthNames.Add("February");
            monthNames.Add("March");
            monthNames.Add("April");
            monthNames.Add("May");
            monthNames.Add("June");
            monthNames.Add("July");
            monthNames.Add("August");
            monthNames.Add("Septemvber");
            monthNames.Add("October");
            monthNames.Add("November");
            monthNames.Add("December");

            double basketPrice = 100;
            Console.WriteLine("Food basket price for " + monthNames[0] + " is: 100");

            for (int i = 1; i < 12; i++)
            {
                basketPrice = basketPrice * 1.015;
                basketPrice = Math.Round(basketPrice, 2);
                Console.WriteLine("Food basket price for " + monthNames[i] + " is: " + basketPrice);
            }

        }
    }
}
