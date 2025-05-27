namespace HetBouwwerk;

internal class Etage
{
    // Instance members. Hebben altijd een instantie (object) nodig om te benaderen
    // Class members. Hebben een class naam nodig.
    public static Lift _elevator = new Lift();
    public int EtageNummer { get; set; } = 0;

    public void ShowLiftStatus()
    {
        _elevator.ShowStatus();
    }
    public void CallLift()
    {
       Etage._elevator.Call(this.EtageNummer);
    }
}
