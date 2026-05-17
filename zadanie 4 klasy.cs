public class Pomoce
{

    public static void pokazGodzine()
    {
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
    }
    public static int dodajDwieLIczby(int x, int y)
    {
        return (int)(x + y);
    }

 }
class Program
{
    static void Main()
    {
        Pomoce.pokazGodzine();

        Console.WriteLine(Pomoce.dodajDwieLIczby(2, 2)); 
        Console.ReadLine();
    }
}