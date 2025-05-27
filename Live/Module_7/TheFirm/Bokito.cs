namespace TheFirm;

// Bokito implementeert de interface IContract
internal class Bokito : IContract
{
    public void Ploetert()
    {
        Werk();
    }

    public  void Werk()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }
}
