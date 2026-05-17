using System.Diagnostics;

public class Operacje
{
    public int wartosc;
    public Operacje()
    {
        wartosc = 0;
    }

    public Operacje(int a)
    {
        wartosc = a;
    }

    public Operacje(int a, int b)
    {
        wartosc = a + b;
    }
    public int wykonajOperacjeMatematycznaDodawanie()
    {
        return wartosc + 7; 
    }

    public int wykonajOperacjeMatematycznaDodawanie(int dodatek)
    {
        return wartosc + dodatek;
    }

    public int wykonajOperacjeMatematycznaMnozenie(int mnoznik1, int mnoznik2)
    {
        return mnoznik1 * mnoznik2;
    }
        static void Main()
    { 
        Operacje rodzaj1 = new Operacje(9);
        Operacje rodzaj2 = new Operacje(0, 0); 
        
        Console.WriteLine(rodzaj1.wykonajOperacjeMatematycznaDodawanie());
        Console.WriteLine(rodzaj2.wykonajOperacjeMatematycznaDodawanie());
        Console.WriteLine(rodzaj1.wykonajOperacjeMatematycznaMnozenie(1, 1));
        Console.WriteLine(rodzaj2.wykonajOperacjeMatematycznaDodawanie(7)); 
    

       Console.ReadLine();
    }
}