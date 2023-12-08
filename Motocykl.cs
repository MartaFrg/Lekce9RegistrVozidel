using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9RegistrVozidel
{
    internal class Motocykl:Vozidlo
    {
        public string typMotocyklu;
        public int pocetKol;

        public Motocykl(int rokVyroby, string barva, string typVozidla, string typMotocyklu, int pocetKol) : base(rokVyroby, barva, typVozidla)
        {
            this.typMotocyklu = typMotocyklu;
            this.pocetKol = pocetKol;
        }
    }
}
