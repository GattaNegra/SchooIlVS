using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // чете от конзолата град (стринг), продукт(стринг) и количество(десетично число) 
            // и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град.

            //град   | coffee | water| beer | sweets| peanuts
            //Sofia  | 0.50   | 0.80 | 1.20 | 1.45  | 1.60
            //Plovdiv| 0.40   | 0.70 | 1.15 | 1.30  | 1.50
            //Varna  | 0.45   | 0.70 | 1.10 | 1.35  | 1.55
          
            Console.Write("Unit: ");
            var unit = (Console.ReadLine().ToLower());
            Console.Write("City: ");
            var city = (Console.ReadLine().ToLower());
            Console.Write("Amount: ");
            var amt = double.Parse(Console.ReadLine());

            double priceCoffee =0;
            double priceWater = 0;
            double priceBeer = 0;
            double priceSweets = 0;
            double pricePeanuts = 0;
            double cashOut = 0;

            if (city=="sofia")
            {
                priceCoffee = 0.50;
                priceWater = 0.80;
                priceBeer = 1.20;
                priceSweets = 1.45;
                pricePeanuts = 1.60;
            }
            if (city == "plovdiv")
            {
                priceCoffee = 0.40;
                priceWater = 0.70;
                priceBeer = 1.15;
                priceSweets = 1.30;
                pricePeanuts = 1.50;
            }
            if (city == "varna")
            {
                priceCoffee = 0.45;
                priceWater = 0.70;
                priceBeer = 1.10;
                priceSweets = 1.35;
                pricePeanuts = 1.55;
            }
            if (unit=="coffee")
            {
                cashOut = amt * priceCoffee;
            }
            if (unit == "water")
            {
                cashOut = amt * priceWater;
            }
            if (unit == "beer")
            {
                cashOut = amt * priceBeer;
            }
            if (unit == "sweets")
            {
                cashOut = amt * priceSweets;
            }
            if (unit == "peanuts")
            {
                cashOut = amt * pricePeanuts;
            }
            Console.WriteLine(cashOut);
        }
    }
}
