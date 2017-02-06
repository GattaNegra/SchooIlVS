using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cels2Far
{
    class Program
    {
        static void Main(string[] args)
        {
            //Умножаваш t (C) по 1.8 и след това прибавяш 32 и получаваш темп. по Фаренхайт 

            double c = double.Parse(Console.ReadLine());
            double f = Math.Round(((c * 1.8) + 32),2);
            Console.WriteLine("Fh: {0}", f);
        }
    }
}
