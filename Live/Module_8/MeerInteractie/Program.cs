namespace MeerInteractie;

internal class Program
{
    static void Main(string[] args)
    {
        Stefan s = new Stefan();
        Patrick p = new Patrick();


        Opdracht v1 = p.HaalBestelling;
        // p.HaalBestelling();
        s.VoerOpdrachtUit(p.HaalBestelling);

        s.VoerOpdrachtUit(Explode);
    }

    static void Explode()
    {
        Console.WriteLine("Kabooom");
    }
}
