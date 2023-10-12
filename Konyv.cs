using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Konyv : IKolcsonozheto
    {
        private string cim;
        private string szerzo;
        private string isbn;

        public Konyv(string cim, string szerzo, string isbn)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.isbn = isbn;
        }

        public int MeddigKolcsonozheto()
        {
            return 14;
        }

        public string MegjelenitendoNev()
        {
            return this.szerzo + " - " + this.cim;
        }
        public override string ToString() 
        {
            return MegjelenitendoNev() + " " + MeddigKolcsonozheto();
        }
    }
}
