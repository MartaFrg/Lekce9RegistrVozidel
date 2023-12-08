using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9RegistrVozidel
{
    internal class SpravceVozidel
    {
        public List<Vozidlo> seznamVozidel;
        public SpravceVozidel()
        {
            seznamVozidel = new List<Vozidlo>();
        }
        internal void PridejAuto()
        {
            int pocetDveri;
            Console.Write("Zadej pocet dveří: ");
            while (!int.TryParse(Console.ReadLine(), out pocetDveri)) Console.WriteLine("Zadej pocet dveří: ");
            Console.Write("Zadej model vozidla: ");
            string model = Console.ReadLine();
            seznamVozidel.Add(new Automobil(RokVyroby(), Barva(), TypVozidla(), pocetDveri, model));

        }
        public void PridejMoto()
        {
            int pocetKol;
            Console.Write("Zadej typ motocyklu: ");
            string typMotocyklu = Console.ReadLine();
            Console.Write("Zadej počet kol motocyklu: ");
            while (!int.TryParse(Console.ReadLine(), out pocetKol)) Console.WriteLine("Zadej pocet dveří: ");
            this.seznamVozidel.Add(new Motocykl(RokVyroby(), Barva(), TypVozidla(), typMotocyklu, pocetKol));
        }
        public void VypisVozidla()
        {
            foreach (var v in seznamVozidel)
            {
                Console.WriteLine(v.GetType().Name);
                Console.WriteLine("Rok výroby: " + v.rokVyroby);
                Console.WriteLine("Typ vozidla: " + v.typVozidla);
                if (v is Automobil automobil) Console.WriteLine("Model automobilu: " + automobil.model);//to jsem si zkoušela obě varianty
                if (v is Motocykl) Console.WriteLine("Model motocyklu: " + ((Motocykl)v).typMotocyklu);
                Console.WriteLine("");
            }
        }
        int RokVyroby()
        {
            int rokVyroby;
            Console.Write("Zadej rok výroby vozidla: ");
            while (!int.TryParse(Console.ReadLine(), out rokVyroby)||rokVyroby<1900||rokVyroby>2023) Console.Write("Zadej rok výroby vozidla: ");
            return rokVyroby;
        }
        string Barva()
        {
            Console.Write("Zadej barvu vozidla: ");
            return Console.ReadLine();
        }
        string TypVozidla()
        {
            Console.Write("Zadej typ vozidla: ");
            return Console.ReadLine();
        }



    }
}
