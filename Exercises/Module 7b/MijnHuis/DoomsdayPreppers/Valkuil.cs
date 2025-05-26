using Afspraken;

namespace DoomsdayPreppers;

public class Valkuil : IDetectable
{
    public void Detecting()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil met puntige spiezen opent");
    }
}