
using System.Collections;


namespace LaatsteType;

internal class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex { Real = 10, Imaginary = 20 };
        Console.WriteLine(c1);
        DoeIets(c1);
        Console.WriteLine(c1);

        int a = 10;
        DoeIetsAnders(c1);

        ArrayList col = new ArrayList();
        col.Add(1);
        col.Add(2);
       // col.Add("3");
        
        foreach(int nr in col)
        {
            Console.WriteLine(nr);
        }
    }

    private static void DoeIetsAnders(object a)
    {
        Console.WriteLine(a);
    }

    private static void DoeIets(Complex cc)
    {
        //cc = new Complex { Real = 100, Imaginary=200 };
        cc.Real = 100;
        cc.Imaginary = 200;
    }
}
