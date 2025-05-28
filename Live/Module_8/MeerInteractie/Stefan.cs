namespace MeerInteractie;

// Blauwdruk van een functie
delegate void Opdracht();

internal class Stefan
{
    public void VoerOpdrachtUit(Opdracht iets)
    {
        Console.WriteLine("Stefan voert uit:");
        iets();
    }
}
