namespace Sklep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategoria elektronika = new Kategoria("Elektronika");

            elektronika.DodajProdukt("Laptop", 2000);
            elektronika.DodajProdukt("Smartfon", 1500);
            elektronika.DodajProdukt("Tablet", 800);

            elektronika.WyswietlProdukty();
        }
    }
}
