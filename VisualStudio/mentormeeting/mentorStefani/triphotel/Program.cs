using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triphotel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
        var season = (Console.ReadLine().ToLower());
            string destination = "";
            string place = "";
            double moneySpent = 0.0;

            if (budget <=100)
            {
                destination = "Bulgaria";
                    if(season=="Summer")
                {
                    place = "camp";
                    moneySpent=budget*0.4;

                  
                }

            }
            //if summer
            //if winter
        }
    }
}
