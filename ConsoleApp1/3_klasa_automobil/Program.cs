using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_klasa_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a = new Automobil();
            Console.WriteLine("Unesi naziv:");
            a.Naziv = Console.ReadLine();
            Console.WriteLine("Unesi godinu proizvodnje:");
            a.GodinaPRoizvodnje = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi osnovnu cijenu:");
            a.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Vaše vozilo se zove {0}, proizvedeno je godine {1} i staro je {2} godina, " +
                "\nte ukupno košta {3} na osnovnu cijenu od {4} kuna.", a.Naziv,
                 a.GodinaPRoizvodnje, a.Starost(), a.UkupnaCijena(), a.OsnovnaCijena);

            Console.ReadLine();
        }
    }
}
