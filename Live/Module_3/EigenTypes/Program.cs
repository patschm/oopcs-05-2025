namespace EigenTypes;

internal class Program
{
    static void Main(string[] args)
    {
        int dag = 3;

        Weekdag dag1 = Weekdag.Zaterdag;
        Console.WriteLine(dag1);
        Console.WriteLine((int)dag1);

        Weekdag dag2 = (Weekdag)5;
        Console.WriteLine(dag2);

        int values = 12;

        Console.WriteLine(values & (int)Weekdag.Donderdag);

    }
}

enum Weekdag : ulong
{
    Maandag = 0,
    Dinsdag = 1,
    Woensdag = 2,
    Donderdag = 4,
    Vrijdag = 8,
    Zaterdag = 16,
    Zondag = 32
}
