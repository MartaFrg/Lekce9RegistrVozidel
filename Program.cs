using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9RegistrVozidel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volba = 0;
            SpravceVozidel autobazarBBB = new SpravceVozidel();
            while (volba != 4)
            {
                Console.WriteLine("Vyber z možností:\t1. přidej automobil\n\t\t\t2. přidej motocykl\n\t\t\t3. vypiš všechna vozidla\n\t\t\t4. UKONČIT");
                while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 4) Console.WriteLine("Zadej možnost 1-4: ");
                switch (volba)
                {
                    case 1:
                        autobazarBBB.PridejAuto();
                        break;
                    case 2:
                        Console.WriteLine();
                        autobazarBBB.PridejMoto();
                        break;
                    case 3:
                        autobazarBBB.VypisVozidla();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;

                }
                if (volba == 1 || volba == 2) { 
                Console.WriteLine("");
                Console.WriteLine("pridano vozidlo " + autobazarBBB.seznamVozidel.Last().GetType().Name);
                Console.WriteLine("celkem vozidel " + autobazarBBB.seznamVozidel.Count);
                Console.WriteLine("");
            }
            }

        }
    }
}
