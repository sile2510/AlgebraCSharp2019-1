using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_2_unos_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<string> RijeciSaA = new List<string>();
            List<string> RijeciSaB = new List<string>();
            List<string> RijeciSaC = new List<string>();
            List<string> OstaleRijeci = new List<string>();
            string a = "";
           
            
            while (a != "kraj")
            {
                Console.WriteLine("Unesite jednu rijec:");
                string rijec = Console.ReadLine();
                a = rijec.ToLower();
                Char[] pojam = a.ToCharArray();

                if (a[0] == 'a')
                {
                    RijeciSaA.Add(rijec);
                }
                else if (a[0] == 'b')
                {
                    RijeciSaB.Add(rijec);
                }
                else if (a[0] == 'c')
                {
                    RijeciSaC.Add(rijec);
                }
                else
                {
                   OstaleRijeci.Add(rijec);
                }
                
            }
            Console.WriteLine("Rijeci koje pocinju s A: ");
            foreach (string item in RijeciSaA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Rijeci koje pocinju sa B: ");
            foreach (string item in RijeciSaB)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Rijeci koje pocinju sa C: ");
            foreach (string item in RijeciSaC)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ostale rijeci: ");
            foreach (string item in OstaleRijeci)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
