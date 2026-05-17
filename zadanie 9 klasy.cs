using System.IO;
using System.Diagnostics;
public class PrzykladPrzeciazenie
{
    public void wypisz(int wartosc) // wypisujem dla zminnej int 
    {
        Console.WriteLine("int =" + wartosc);
    }

    public void wypisz(double wartosc) // wypisujemy dla zmiennje double 
    {
        Console.WriteLine("double =" + wartosc);    

    }
    public void wypisz(string wartosc) // wypisujemy dla zmiennej string 
    {
        Console.WriteLine("string = " + wartosc);
    }
    // POMYSŁ ZACIĄGNIĘTY Z INTERNETU!!!
    public void wypisz(string[] daneDoArkusza)
    {
        string nazwaPliku = "raport.csv";

        string liniaCsv = string.Join(";", daneDoArkusza);


        File.WriteAllText(nazwaPliku, liniaCsv);

        Console.WriteLine("Plik Arkusza" + nazwaPliku);

        Process.Start(new ProcessStartInfo
        {
            FileName = nazwaPliku,
            UseShellExecute = true,
        });
    }
}
class Program
{
    static void Main()
    { 
        // wywołanie metody przeciążania
        PrzykladPrzeciazenie rodzaj = new PrzykladPrzeciazenie(); 

        rodzaj.wypisz(100);
        rodzaj.wypisz(19.2);
        rodzaj.wypisz("Przeciążenie argument tekst");
        string[] mojeDane = { "NR ALBUMU", "IMIE", "WYNIK", "UWAGI" };
        rodzaj.wypisz(mojeDane);

        Console.ReadLine(); 
    }
}