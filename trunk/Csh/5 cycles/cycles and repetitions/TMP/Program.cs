using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int palnoletniizb =int.Parse(Console.ReadLine());

            for (int izbirNomer=1; izbirNomer<=palnoletniizb;izbirNomer++)
                            //..kebapcheta,kufteta
                            Console.WriteLine("{0}", izbirNomer);
                            */

            var citizensAbleToVote = int.Parse(Console.ReadLine());
            for (var izbiratel =1; izbiratel<=citizensAbleToVote;izbiratel++)

            { var buletinenumber = int.Parse(Console.ReadLine()) ;

                Console.WriteLine("You voted for {0}", buletinenumber);

            }
        }
    }
}
