using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad2deg
{
    class Program
    {
        static void Main(string[] args)
        {
            //The angle between two lines are represented by means of Degrees and Radians. 
            //The total angle in a circle is 360 degrees or 2π radians.
            //Radians to Degrees Formula is used to convert the angle which is represented 
            //in terms of radians into degrees.
            //Radians to Degrees Formula is given as:
            //deg=(rad*180)π
            //чете ъгъл в радиани (rad) и го преобразува в градуси (deg). 
            //Числото π в C# програми е достъпно чрез Math.PI. 
            //Закръглете резултата до най-близкото цяло число използвайки Math.Round(). 

            double rad = double.Parse(Console.ReadLine());
            double deg = Math.Round(((rad *180)/Math.PI), 2);
            Console.WriteLine("Deg: {0}", deg);
        }
    }
}
