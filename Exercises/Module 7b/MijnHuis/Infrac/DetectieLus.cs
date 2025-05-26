using Afspraken;

namespace Infrac;

public delegate void DetectHandler();

public class DetectieLus
{
    private List<IDetectable> devices = new List<IDetectable>();
    public event DetectHandler Detecting;

    public void Connect(IDetectable detectable)
    {
        devices.Add(detectable);
    }
    public void Detect()
    {
        Console.WriteLine("Hmmm, we zien iets...");
        //foreach (IDetectable device in devices)
        //{
        //    device.Detecting();
        //}
        Detecting?.Invoke();
    }
}