namespace Konstruktory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uczen uczen = new Uczen("Jan", "Kowalski", 16);

            var listaObecnoisci = new List<int> { 1, 1, 0, 1, 1 };
            var listaOcen = new List<int> { 5, 4, 3, 4, 5 };

            Uczen uczen1 = new Uczen("Piotr", "Kowalski", 16, listaObecnoisci, listaOcen);

            Console.WriteLine("oceny ucznia Jan");
            foreach (var ocena in uczen.Oceny)
            {
                Console.WriteLine(ocena);
            }

            Console.WriteLine("oceny ucznia Piotr");
            foreach (var ocena in uczen1.Oceny)
            {
                Console.WriteLine(ocena);
            }
        }
    }

}
