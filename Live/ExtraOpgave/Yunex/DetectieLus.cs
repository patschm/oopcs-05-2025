using Standards;

namespace Yunex;

public delegate void DetDel();

public class DetectieLus
{
    private List<IObservable> _observers = new List<IObservable>();
    public event DetDel? Detect;
    public event EventHandler? Detect2;
    private List<DetDel> devices = new List<DetDel>();

    public void Connect(IObservable device)
    {
        _observers.Add(device);
    }
    public void Connect(DetDel device)
    {
        Detect +=device;
    }
    public void Detecteer()
    {
        Console.WriteLine("De lus ziet iets...");
        Detect?.Invoke();
        Detect2?.Invoke(this, EventArgs.Empty);
        foreach (var device in _observers)
        {
            device.Notify();
        }
    }
}
