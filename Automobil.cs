using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9RegistrVozidel
{
    internal class Automobil:Vozidlo
    {
        public int pocetDveri;
        public string model;

        public Automobil(int rokVyroby, string barva, string typVozidla, int pocetDveri, string model) : base(rokVyroby, barva, typVozidla)
        {
            this.pocetDveri = pocetDveri;
            this.model = model;
        }
    }
}
