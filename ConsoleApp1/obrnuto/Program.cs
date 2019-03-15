using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string str, obrnuto = "";
            Console.WriteLine("Unesi tekst: ");
            str = Console.ReadLine();

            a = str.Length - 1;

            while (a >= 0)
            {
                obrnuto += str[a];
                a--;
            }
            Console.WriteLine("Obrnuti teks je: \n{0}", obrnuto);
            Console.ReadLine();
        }
    }
}
