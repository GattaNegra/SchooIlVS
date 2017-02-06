using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageandgenderaddress
{
    class Program
    {
        static void Main(string[] args)
        {
            //въвежда възраст (десетично число) и пол(“m” или “f”) и отпечатва обръщение измежду следните:
            //“Mr.” – мъж(пол “m”) на 16 или повече години
            //“Master” – момче(пол “m”) под 16 години
            //“Ms.” – жена(пол “f”) на 16 или повече години
            //“Miss” – момиче(пол “f”) под 16 години

            var age = decimal.Parse(Console.ReadLine());
            var gender = (Console.ReadLine());

            if (age < 16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
            else if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }


            if (age >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
        





    }
}
}
