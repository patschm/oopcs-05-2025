namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {


        int aa = 10;
        switch (aa)
        {
            case -1:
            case 0:
                Console.WriteLine("nul");
                break;
            case 1:
                Console.WriteLine("een");
                break;
            case > 2:
                Console.WriteLine("Groter dan twee");
                break;
            case int _ when aa > 5 && aa < 10:
                break;
            default:
                break;
        }


        // Typenaam variable
        int age = 45;
        string? name = null;

        {
            int jaar = 1998;
        }

        bool ba = false;
        bool bb = false;

        bool bc = ba & DoeIets();

        int? len = null;
        int len2 = len ?? 42;

        len ??= 42;

        int? lengte = name?.Length;

        long x = 1000;
        int y = (int)x;

        IFormattable f1 = (IFormattable)x;
        IFormattable f = x as IFormattable;



        Console.WriteLine($"{name} {++age}");
    }

    static bool DoeIets()
    {
        Console.WriteLine("Doet Iets");
        return true;
    }
}
