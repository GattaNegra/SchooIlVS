using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metric
{
    class metric
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, която преобразува разстояние между следните 8 мерни единици: m, mm, cm, mi, in,
            //km, ft, yd
            //amount
            //входна единица
            //изходна единица

           // double m = 1;
            //1 meter(m) 1000 millimeters(mm)
            double mmr = 1000;
            //1 meter(m) 100 centimeters(cm)
            double cmr = 100;
            //1 meter(m) 0.000621371192 miles(mi)
            double mir = 0.000621371192;
            //1 meter(m) 39.3700787 inches(in)
            double inr = 39.3700787;
            //1 meter(m) 0.001 kilometers(km)
            double kmr = 0.001;
            //1 meter(m) 3.2808399 feet(ft)
            double ftr = 3.2808399;
            //1 meter(m) 1.0936133 yards(yd)
            double ydr = 1.0936133;

            Console.WriteLine("Enter Amount:");
            double amt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Input Unit:");
            var iU = Console.ReadLine();
            Console.WriteLine("Enter Output Unit:");
            var oU = Console.ReadLine();

            
            double amt2;
            double amt3;

            if (iU.ToUpper() == "M")
            //m to m = amt
            {
                amt2 = amt;
            }
            else if (iU.ToUpper() == "MM")
            //mm to m = amt / changerate
            {
                amt2 = amt / mmr;
            }
            else if (iU.ToUpper() == "CM")
            //cm to m = amt / changerate
            {
                amt2 = amt / cmr;
            }
            else if (iU.ToUpper() == "MI")
            //mi to m = amt / changerate
            {
                amt2 = amt / mir;
            }
            else if (iU.ToUpper() == "IN")
            //in to m = amt / changerate
            {
                amt2 = amt / inr;
            }
            else if (iU.ToUpper() == "KM")
            //km to m = amt / changerate
            {
                amt2 = amt / kmr;

            }
            else if (iU.ToUpper() == "FT")
            //ft to m = amt * changerate
            {
                amt2 = amt / ftr;
            }
            else if (iU.ToUpper() == "YD")
            //yd to m = amt * changerate
            {
                amt2 = amt / ydr;
            }
            else
            {
                Console.WriteLine("Wrong Input Unit");
                return;
            }

            //
            if (oU.ToUpper() == "M")
            //m to m = amt2
            {
                amt3 = amt2;
            }
            else if (oU.ToUpper() == "MM")
            //m to mm = amt2 * changerate
            {
                amt3 = amt2 * mmr;
            }
            else if (oU.ToUpper() == "CM")
            //m to cm = amt2 * changerate
            {
                amt3 = amt2 * cmr;
            }
            else if (oU.ToUpper() == "MI")
            //m to mi = amt2 * changerate
            {
                amt3 = amt2 * mir;
            }
            else if (oU.ToUpper() == "IN")
            //m to in = amt2 * changerate
            {
                amt3 = amt2 * inr;
            }
            else if (oU.ToUpper() == "KM")
            //m to km = amt2 * changerate
            {
                amt3 = amt2 * kmr;
            }
            else if (oU.ToUpper() == "FT")
            //m to ft = amt2 * changerate
            {
                amt3 = amt2 * ftr;

            }
            else if (oU.ToUpper() == "YD")
            //m to yd = amt2 * changerate
            {
                amt3 = amt2 * ydr;
            }
            else
            {
                Console.WriteLine("Wrong Input Unit");
                return;
            }
            Console.WriteLine(amt3+" "+iU);





        }
    }
}
