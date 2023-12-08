using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9RegistrVozidel
{
    internal abstract class Vozidlo
    {
        public readonly int rokVyroby;
        public string barva;
        public string typVozidla;
        public Vozidlo(int rokVyroby, string barva, string typVozidla)
        {
            this.rokVyroby = rokVyroby;
            this.barva = barva;
            this.typVozidla = typVozidla;
        }
    }
}
