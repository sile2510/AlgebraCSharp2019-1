using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();

            //inicijalizacija objekta
            Console.WriteLine("Unesi ime učenika:");
            uc1.ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime učenika:");
             


            Console.WriteLine("Unesi prezime učenika:");
            Console.WriteLine("Unesi ocjenu iz matematike:");
            Console.WriteLine("Unesi ocjenu iz biologije:");
            Console.WriteLine("Unesi ocjenu iz engleskog:");

            // instanciraj novi objekt klase Ucenik
            Ucenik uc2 = new Ucenik("Perica");

            Console.WriteLine("Ime ucenika je " + uc1.ime + " i " + uc2.ime);
            Console.ReadKey();





        }
    }
}
