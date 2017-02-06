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


            var chocneed = int.Parse(Console.ReadLine());
            var enoughchoc = chocneed;
            var chocolate = 0;
            var raft = (Console.ReadLine());


            
while (!enoughchoc)
            {
                Console.WriteLine(chocolate);
                Console.WriteLine("na rafta");
               raft= Console.ReadLine();
                if (raft!="chocolate")
                {
                    continue;
                }
                else
                {
                    chocolate += 1;
                }
                
            }
      Console.WriteLine("Got enough!");
        }
    }
}
