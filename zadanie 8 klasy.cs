using System.Diagnostics;
using static System.Net.WebRequestMethods;

public class Przyklad
{
    // Tutaj wypisuje double 
    public double polePierwsze { get; set; }
    public double poleDrugie { get; set; }

    public void wypisz()
    {
        Console.WriteLine(polePierwsze.ToString("F1") + "+i" + poleDrugie.ToString("F1"));
    }
    public Przyklad()
    {
        polePierwsze = 0; 
        poleDrugie = 0; 
    } 
    public Przyklad(double wartoscPierwsze)
    {
        polePierwsze = wartoscPierwsze;
        poleDrugie = 0;
    }
    // dwie wartosci 
    public Przyklad(double x, double y)
    {
        polePierwsze = x;
        poleDrugie = y;
    }
}
class Program
{
    static void Main() // początek wykonywania porgamu 
    { //warto programować przy dobrej muzyce 
        string linkdoYT = "https://www.youtube.com/watch?v=cSnkWzZ7ZAA";
        Process.Start(new ProcessStartInfo
        {
            FileName = linkdoYT,
            UseShellExecute = true
        });
       // a za niedługo wakacje 
        Przyklad obiekt1 = new Przyklad();
        Przyklad obiekt2 = new Przyklad(10);
        Przyklad obiekt3 = new Przyklad(50, 8);

        obiekt1.wypisz();
        obiekt2.wypisz();
        obiekt3.wypisz();
    }
   
}
