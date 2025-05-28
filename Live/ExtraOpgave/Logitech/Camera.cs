using Standards;

namespace Logitech;

public class Camera : IObservable
{
    public void Notify()
    {
        StartOpname();
    }

    public void StartOpname()
    {
        Console.WriteLine("De camera neemt het tafereeltje op");
        throw new NotImplementedException();
    }
}
