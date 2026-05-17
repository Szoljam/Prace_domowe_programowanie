public class Przykład
{
    public int x; 
    public int y; 
}

public class Wypisz
{
    public Przykład wartosc;
    public Przykład wartosc2; 
}
class Program
{
    static void Main()
    {
        Przykład p1 = new Przykład();

        p1.x = 10;
        p1.y = 10;

        Przykład p2 = new Przykład();

        p2.x = 19;
        p2.y = 19;

        Wypisz mojwypisz = new Wypisz(); 
        mojwypisz.wartosc = p1; 
        mojwypisz.wartosc2 = p2;

        Console.WriteLine(mojwypisz.wartosc2.x);

        Console.WriteLine(mojwypisz.wartosc.y); 
        
        Console.ReadLine(); 
    }
}