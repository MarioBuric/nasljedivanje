using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            u1.Ime = "Marko";
            u1.Prezime = "Marulić";
            u1.Razred = 3;

            Nastavnik n1 = new Nastavnik();
            n1.Ime = "MrKee ";
            n1.Prezime = "ItMaster";
            n1.Predmet = "Programiranje";
              



        }
    }
}
