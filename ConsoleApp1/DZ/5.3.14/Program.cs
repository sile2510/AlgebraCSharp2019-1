using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("neparni brojevi iz intervala [1, 100] su:");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write("{0}", i.ToString());
            }
            Console.ReadKey();
        }
    }
}
