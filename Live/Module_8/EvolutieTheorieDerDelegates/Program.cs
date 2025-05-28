namespace EvolutieTheorieDerDelegates;


delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002/2003 .NET 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // 2005. .NET 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int y = 100;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + y;
        };

        result = m3(3, 4);

        // 2008. .NET 3.0/3.5
        // Lambda
        MathDel m4 = (a, b) => a + b + y;
        result = m4(4, 5);

        // Procedures
        Action<string, int> a = (msg, nr)=> Console.WriteLine(msg + nr);
        a("Hallo", 42);

        // Functions returning a bool
        Predicate<string> xy = s => s.Length == 4;

        // Functions
        //Func<int, int, int> m5 = Add;
        Func<int, int, int> m5 = (a, b) => a + b;
       result = m5(5,6);

       



        Console.WriteLine(result);

        // 2017
        int InlineAdd(int x, int z)
        {
            return x + z + y;
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
