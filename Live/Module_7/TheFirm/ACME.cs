namespace TheFirm;

internal class ACME
{
    private List<IContract> werkenemers = new List<IContract>();

    public void Hire(IContract emp)
    {
        werkenemers.Add(emp);
    }

    public void Start()
    {
        Console.WriteLine("ACME starts producing..");
        foreach(IContract werknemer in werkenemers)
            werknemer?.Ploetert ();
    }
}
