﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();

            Console.Write("Unesi marku automobila: ");
            automobil.MarkaAutomobila = Console.ReadLine();
            Console.Write("Unesi broj konjskih snaga: ");
            automobil.KS = double.Parse(Console.ReadLine());
            Console.Write("Unesi osnovnu cijenu: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Iznos poreza: {0}\nUkupna cijena: {1}", automobil.IznosPoreza(), automobil.UkupnaCijena());

            Console.ReadKey();



        }
    }
}
