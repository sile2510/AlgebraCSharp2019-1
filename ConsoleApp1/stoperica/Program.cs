using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoperica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pritisni nešto za start");
            Console.ReadKey();
            DateTime d1 = DateTime.Now;

            Console.WriteLine("Pritisni nešto za kraj");
            Console.ReadKey();
            DateTime d2 = DateTime.Now;
            TimeSpan ts = d2.Subtract(d1);

            Console.WriteLine("Poteklo vrijeme je {0}:{1}:{2} {3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.ReadKey();
        }
    }
}
