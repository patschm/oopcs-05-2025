using Standards;

namespace Yunex;

public class DetectieLus
{
    private List<IObservable> _observers = new List<IObservable>();

    public void Connect(IObservable device)
    {
        _observers.Add(device);
    }
    public void Detecteer()
    {
        Console.WriteLine("De lus ziet iets...");
        foreach (var device in _observers)
        {
            device.Notify();
        }
    }
}
