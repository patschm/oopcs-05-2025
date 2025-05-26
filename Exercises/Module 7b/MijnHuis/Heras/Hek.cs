using Afspraken;

namespace Heras;

public class Hek : IDetectable
{
    public void Detecting()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}