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
            long j = 600851475143;
            long x = 3;
            long z;
            long q;
            l.Add(x);

            for (long y = 2; y <= x - 1; y++)
            while(x <= 600851475143)
            {
                z = x % y;
                x = x + 1;

                if (z != 0)
                {
                    q = j % x;
                    if (q == 0)
                    {
                        l.Add(x);
                    }
                }
            }
            Console.WriteLine(l);
            Console.Read();
        }
    }
}
