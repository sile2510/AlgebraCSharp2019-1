using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozz("Boris");
            Pozz("Boris", "Šipoš");
            Console.ReadKey();
        }
        static void Pozz(string ime)
        {
            Console.WriteLine("Bok, " + ime + "!");
        }
        static void Pozz(string ime, string prezime)
        {
            Console.WriteLine("Bok, " +ime+" " +prezime+ "!");
        }
    }
}
