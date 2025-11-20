using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Uczen
    {
        public string Imie;
        public int Wiek;

        // Konstruktor
        public Uczen(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Cześć, mam na imię {Imie} i mam {Wiek} lat.");
        }
    }
}
