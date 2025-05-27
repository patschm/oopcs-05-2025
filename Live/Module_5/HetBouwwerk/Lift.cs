namespace HetBouwwerk;

internal class Lift
{
    private int HuidigeVerdieping { get; set; } = 0;

    public void Call(int target)
    {
        Console.WriteLine($"De lift zoemt naar de {target}e verdieping");
        HuidigeVerdieping = target;
    }
    public void ShowStatus()
    {
        Console.WriteLine($"De lift staat nu op de {HuidigeVerdieping}e verdieping");
    }
}