using Standards;

namespace Heras;

public class Hek : IObservable
{
    public void Notify()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
