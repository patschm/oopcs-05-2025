
using System.Text;

namespace Generieken;

internal class Program
{
    static void Main(string[] args)
    {
        var fac1 = new DeFabriek<StringBuilder>();
        var bld = fac1.Bouw();
       // bld.Append

        Point<float> point = new Point<float> { X = 20, Y = 100 };
        Console.WriteLine(point);

        string a = 10.ToString();
        string b = 20.ToString();

        Console.WriteLine($"{a}, {b}");
        //Swap<string>(ref a, ref b);
        Swap(ref a, ref b);
        Console.WriteLine($"{a}, {b}");
    }


    private static void Swap<T>(ref T a, ref T b)// where T : IFormattable
    {
        T tmp = a;
        a = b;
        b = tmp;
    }
    private static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    private static void Swap(ref uint a, ref uint b)
    {
        uint tmp = a;
        a = b;
        b = tmp;
    }
    private static void Swap(ref long a, ref long b)
    {
        long tmp = a;
        a = b;
        b = tmp;
    }
}
