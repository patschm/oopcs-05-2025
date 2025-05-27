using Standards;

namespace DoomsdayPreppers;

public class Valkuil : IObservable
{
    public void Notify()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil opent");
    }
}
