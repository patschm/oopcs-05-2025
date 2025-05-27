
namespace TheFirm;

internal class Peter : Werknemer
{
    public void Bouwt()
    {
        Console.WriteLine("Peter maakt aardbevingspillen");
    }
    public override void Werk()
    {
        Bouwt();
    }
}
