namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        ACME comp = new ACME();
        Jurjen j = new Jurjen();
        Peter p = new Peter();
        IContract k = new Klaas();
        Bokito bokito = new Bokito();

        comp.Hire(j);
        comp.Hire(p);
        comp.Hire(k);
        comp.Hire(bokito);


        comp.Start();
    }
}
