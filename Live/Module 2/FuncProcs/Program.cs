
namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(a);
        //int aa = a;
        DoeIets(out a);
        Console.WriteLine(a);

        DoeIets(out int x);
        Console.WriteLine(x);

        int nummer = GeefNummer();
        //int result = TelOp(nummer, 2, 3);
       // int result = TelOp(new int[] { nummer, 1, 2, 3, 4 });
        int result = TelOp(nummer, 1, 2, 3, 4);
        ShowNumber(result);

        int GetNumber()
        {
            return 42 + x;
        }
    }

    //private static void DoeIets(ref int aa)
    static void DoeIets(out int aa)
    {
        aa = 50;
    }

    // Procedure
    static void ShowNumber(int nr)
    {
        int age;
        Console.WriteLine($"Het nummer is {nr}");
    }

    // Function
    static int GeefNummer()
    {
        do
        {
            Console.WriteLine("Geef een geldig nummer");
            string snr = Console.ReadLine();
            if (int.TryParse(snr, out int b))
            {
                return b;
            }
        }
        while (true);
    }

    static int TelOp(int a, int b)
    {
        return a + b;
    }
    static int TelOp(int a, int b, int c)
    {
        return a + b + c;
    }

    static int TelOp(params int[] nrs)
    {
        return nrs.Sum();
    }
}
