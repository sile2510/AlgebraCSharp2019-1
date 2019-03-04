using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            float prosjek;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Unesi {0}. prirodan broj:", i.ToString());
                suma += int.Parse(Console.ReadLine());
            }
            prosjek = (float)suma / 5;
            Console.Write("Suma = {0} \n Prosjek = {1}", suma, prosjek);
            Console.ReadKey();
        }
    }
}
