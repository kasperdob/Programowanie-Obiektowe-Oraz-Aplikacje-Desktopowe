namespace Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uczen jan = new Uczen("Jan", 16);
            jan.PrzedstawSie();  // Wynik: Cześć, mam na imię Jan i mam 16 lat.
        }
    }
}
