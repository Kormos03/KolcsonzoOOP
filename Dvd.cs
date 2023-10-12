using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Dvd : IKolcsonozheto, IComparable<Dvd>
    {
        private List<Dvd> dvdk;
        private string cim;
        private int hossz;

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
            Dvdk = new List<Dvd>();
           
        }

        public List<Dvd> Dvdk { get => dvdk; set => dvdk = value; }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return this.cim + " ("+this.hossz+")";
        }
        public void fillDvd()
        {
            this.Dvdk.Add(new Dvd("Titanic", 300));
            this.Dvdk.Add(new Dvd("Saw", 230));
            this.Dvdk.Add(new Dvd("LongDvd", 400));
            this.Dvdk.Add(new Dvd("ShortDvd", 100));
            this.Dvdk.Add(new Dvd("AAAAA", 310));
        }
        public override string ToString()
        {
            return MegjelenitendoNev() + " " + MeddigKolcsonozheto();
        }

            public int CompareTo(Dvd dvd1)
            {
                if (this.hossz < dvd1.hossz) { return -1; }
                else if (this.hossz > dvd1.hossz) { return 1; }
                else { return 0; }
            }
        
      
    }
}
