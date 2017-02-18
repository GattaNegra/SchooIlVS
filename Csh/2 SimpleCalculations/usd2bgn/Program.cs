using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usd2bgn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма за конвертиране на щатски долари(USD) в български лева(BGN).
            //Закръглете резултата до 2 цифри след десетичната запетая.
            //Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.
            double conv = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = Math.Round((conv*usd), 2);
            Console.WriteLine("BGN: {0}", bgn);
        }
    }
}
