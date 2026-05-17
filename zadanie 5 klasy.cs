using System.Drawing;

public class Punkt
{

    public int x; 
    public int y; 
}

public class Linia
{
    public Punkt poczatek;
    public Punkt koniec;
} 

class Program
{
    static void Main()
    {
        Punkt p1 = new Punkt();
        p1.x = 1;
        p1.y = 1;
        
        Punkt p2 = new Punkt();
        p2.x = 3;
        p2.y = 3;
            
        Linia mojaLinia = new Linia();
        mojaLinia.poczatek = p1;
        mojaLinia.koniec = p2;

        Console.WriteLine(mojaLinia.koniec.x);

        Console.WriteLine(mojaLinia.poczatek.y); 

        Console.ReadLine(); 
    }
}

