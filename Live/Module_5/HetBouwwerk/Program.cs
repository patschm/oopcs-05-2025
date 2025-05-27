

namespace HetBouwwerk;

internal class Program
{
    static void Main(string[] args)
    {
        //DeToren();
        EenPunt();
        
    }

    private static void EenPunt()
    {
        Point p1 = new Point { X=10, Y=20 };
        Point p2 = new Point {X=100, Y=200 };

        //Point p3 = Point.Add(p1, p2);

        Point p3 = p1 + p2;

        p1.Show();
        p2.Show();
        p3.Show();

        p1.Reset();

        int y = 20;
        y.SponsoredBy("Patrick");
    }

    private static void DeToren()
    {
        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }



        flat[40].CallLift();


        foreach (Etage e in flat)
        {
            e.ShowLiftStatus();
        }
    }
}
