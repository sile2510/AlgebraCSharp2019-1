using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int koliko = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    koliko++;
                }
            }
            Console.WriteLine("djeljivi sa 7, a nedjeljivi s 3 iz intervala [1, 1000] ima {0}", koliko);
            Console.ReadKey();
        }
    }
}
