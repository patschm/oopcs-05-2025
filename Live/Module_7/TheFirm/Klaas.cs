
namespace TheFirm;

internal class Klaas : Werknemer
{
    public void DoetIets()
    {
        Console.WriteLine("Klaas schildert tunnels op rotswanden");
    }

    public override void Werk()
    {
        DoetIets();
    }
}
