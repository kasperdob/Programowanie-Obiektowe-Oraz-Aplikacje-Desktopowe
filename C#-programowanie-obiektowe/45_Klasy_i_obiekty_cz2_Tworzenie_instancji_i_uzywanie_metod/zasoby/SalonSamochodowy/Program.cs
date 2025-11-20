namespace SalonSamochodowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod mercedes = new Samochod();

            mercedes.Marka = "Mercedes";
            mercedes.Kolor = "Czarny";
            mercedes.RokProdukcji = 2020;
            mercedes.Dostepnosc = true;

            Samochod audi = new Samochod();

            audi.Marka = "Audi";
            audi.Kolor = "Bialy";
            audi.RokProdukcji = 2019;
            audi.Dostepnosc = false;


            mercedes.UruchomSilnik();
            mercedes.Go();

            audi.Go();
        }
    }
}
