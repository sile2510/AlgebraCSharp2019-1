﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2._2_klucna_rijec_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Inicijaliziraj(out a);
            Console.WriteLine("a = {0}", a);
            Console.ReadKey();
        }

        private static void Inicijaliziraj(out int a)
        {
            a = 1;
        }
    }
}
