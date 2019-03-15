using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_klasa_automobil
{
    class Automobil
    {
        private string naziv;
        private int godinaPRoizvodnje;
        private double osnovnaCijena;

        public string Naziv { get => naziv; set => naziv = value; }
        public int GodinaPRoizvodnje { get => godinaPRoizvodnje; set => godinaPRoizvodnje = value; }
        public double OsnovnaCijena { get => osnovnaCijena; set => osnovnaCijena = value; }

        public int Starost()
        {
            int godine = DateTime.Now.Year - GodinaPRoizvodnje;
            return godine;
        }
        public double UkupnaCijena()
        {
            double ukupnaCijena = 0;
            

                if (osnovnaCijena <= 70000)
            {
                ukupnaCijena = osnovnaCijena * 1.3;
            }
            else if (osnovnaCijena > 70000 && osnovnaCijena < 100000)
            {
                ukupnaCijena = osnovnaCijena * 1.4;
            }
            else if (osnovnaCijena >= 100000)
            {
               ukupnaCijena = osnovnaCijena * 1.5;
            }
            return ukupnaCijena;
        }


    }
}
