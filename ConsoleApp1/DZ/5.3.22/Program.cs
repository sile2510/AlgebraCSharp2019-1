using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            string odgovor = "D";
            while (odgovor == "D" || odgovor == "d")
            {
                Console.Write("unesi 1. prirodan broj: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("unesi 2. prirodan broj: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("unesi računsku operaciju (+, -, *, /): ");
                operacija = Console.ReadLine();

            switch (operacija)
                {
                    case "+":
                        Console.WriteLine("zbroj: {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("razlika: {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("umnožak: {0}", a * b);
                        break;
                    case "/":
                        Console.WriteLine("kvocijent: {0}", a / b);
                        break;
                    default:
                        Console.WriteLine("nepoznato");
                        break;
                }
                Console.Write("ponovno računanje (d/n)? ");
                odgovor = Console.ReadLine();
            }
        }
    }
}
