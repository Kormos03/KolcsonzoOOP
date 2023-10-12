using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Ujsag : IKolcsonozheto
    {
        private string cim;
        private int kiadasEv;
        private int kiadasHet;

        public Ujsag(string cim, int kiadasEv, int kiadasHet)
        {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            this.kiadasHet = kiadasHet;
        }


        public int MeddigKolcsonozheto()
        {
            return 0;
        }
        public string MegjelenitendoNev()
        {
            return this.cim + " " + this.kiadasEv + "/" + this.kiadasHet;
        }
        public override string ToString()
        {
            return MegjelenitendoNev() + " " + MeddigKolcsonozheto();
        }
    }
}
