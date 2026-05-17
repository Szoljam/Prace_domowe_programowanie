using System.Runtime.CompilerServices;

public class Punkt
{
    public int x { get; set; }
    public int y { get; set; }

    public Punkt(int x, int y)
    {
    this.x = x; 
    this.y = y;
    }
    public override string ToString()
    {
        return x + "\n" + y;
    }
}
public class LInia
{
    public Punkt poczatek { get; set; }
    public Punkt koniec { get; set; }

    public LInia(Punkt poczatek, Punkt koniec)
    {
        this.poczatek = poczatek;
        this.koniec = koniec;
    } 
    public LInia(int x1, int y1, int x2, int y2)
    {
        this.poczatek = new Punkt(x1, y1);
        this.koniec = new Punkt(x2, y2);
    }
} 
class Program
{
    static void Main()
    {
        Punkt p1 = new Punkt(10, 20);

        Console.WriteLine(p1.ToString());

        LInia mojaLInia = new LInia(4, 5, 10, 20);
        Console.WriteLine("LInia");
        Console.WriteLine(mojaLInia.poczatek.x);
        Console.WriteLine(mojaLInia.koniec.y);

        Punkt pA = new Punkt(1, 1);
        Punkt pB = new Punkt(9, 9); 
        LInia innaLInia = new LInia (pA, pB); 

        Console.ReadLine(); 
    }
}