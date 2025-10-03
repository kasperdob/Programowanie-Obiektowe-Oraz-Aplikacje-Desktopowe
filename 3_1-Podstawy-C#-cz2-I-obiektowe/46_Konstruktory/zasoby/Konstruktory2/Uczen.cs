using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory2
{
    public class Uczen
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public List<int> LiczbaObecnosci { get; set; }
        public List<int> Oceny { get; set; }

        public Uczen(string Imie, string Nazwisko, int Wiek) 
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;

            LiczbaObecnosci = new List<int>();
            Oceny = new List<int>();
        }

        public Uczen(
            string Imie, 
            string Nazwisko, 
            int Wiek,
            List<int> LiczbaObecnosci,
            List<int> Oceny)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
            this.LiczbaObecnosci = LiczbaObecnosci;
            this.Oceny = Oceny;
        }

        public bool CzyKlasyfikowany() 
        {
            var liczbaOcen = Oceny.Count;
            var liczbaObecnosci = LiczbaObecnosci.Count();

            if (liczbaOcen >= 3 && liczbaObecnosci > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SredniaOcen()
        {
            if (Oceny.Count == 0)
            {
                return 0;
            }
            else
            {
                return Oceny.Average();
            }
        }

        
    }
}
