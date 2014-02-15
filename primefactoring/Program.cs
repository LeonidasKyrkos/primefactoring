using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> l = new List<long>();
            long BigNumber = 600851475143;
            long Primefactor = 3;
            long Primecheck;
            long Primecheck2;
            l.Add(Primefactor);

            for (long y = 2; y <= Primefactor - 1; y++)
            while(Primefactor <= BigNumber)
            {
                Primecheck = Primefactor % y;
                Primefactor = Primefactor + 1;

                if (Primecheck != 0)
                {
                    Primecheck2 = BigNumber % Primefactor;
                    if (Primecheck2 == 0)
                    {
                        l.Add(Primefactor);
                    }
                }
            }
            Console.WriteLine(l);
            Console.Read();
        }
    }
}
