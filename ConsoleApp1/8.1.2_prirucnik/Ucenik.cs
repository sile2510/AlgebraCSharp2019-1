namespace _8._1._2_prirucnik
{
    internal class Ucenik
    {
        public string ime = "";
        public System.DateTime datumNastanka;
        public string prezime = "";
        public int ocjenaizMatematike = 0;
        public int ocjenaizEngleskog = 0;
        public int ocjenaizBiologije = 0;

        public Ucenik()
        {
            this.datumNastanka = System.DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.ime = v;
        }


        public Ucenik(string v, string prez)
        {
            this.ime = v;
            this.prezime = prez;
        }
    }
}