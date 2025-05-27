
namespace TheFirm;

internal class Jurjen : Werknemer
{
    public void Creeert()
    {
        Console.WriteLine("Maakt nu raketrolschaatsen");
    }
    public override void Werk()
    {
        Creeert();
    }
}
