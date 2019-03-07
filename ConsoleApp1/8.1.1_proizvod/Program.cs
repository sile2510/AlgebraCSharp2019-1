using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi naziv proizvoda: ");
            Proizvod proizvod = new Proizvod(Console.ReadLine());

            Console.Write("Unesi cijenu proizvoda: ");
            proizvod.Cijena = double.Parse(Console.ReadLine());
            Console.Write("Unesi marzu proizvoda: ");
            proizvod.Marza = double.Parse(Console.ReadLine());
            Console.Write("Unesi porez na proizvoda: ");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena proizvoda {0} je {1}.", proizvod.Naziv, proizvod.MPC());

            Console.ReadKey();



        }
    }
}
