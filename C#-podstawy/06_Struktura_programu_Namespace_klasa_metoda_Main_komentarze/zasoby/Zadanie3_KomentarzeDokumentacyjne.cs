using System;

class Program
{
    /// <summary>
    /// Dodaje dwie liczby całkowite.
    /// </summary>
    /// <param name="x">Pierwsza liczba</param>
    /// <param name="y">Druga liczba</param>
    /// <returns>Suma liczb x i y</returns>
    static int Dodaj(int x, int y)
    {
        return x + y;
    }

    static void Main()
    {
        Console.WriteLine(Dodaj(3, 7));
    }
}
