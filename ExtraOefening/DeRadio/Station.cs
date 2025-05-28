public delegate void ReceiveMethod(string message);

public class Station
{
    private ReceiveMethod? subscribers;
    public event EventHandler<MessageEventArgs> MessageEvt;

    public event ReceiveMethod Message
    {
        add { subscribers += value; }
        remove { subscribers -= value; }
    }
    public void Broadcast()
    {
        // Broadcasting logic here
        Console.WriteLine("Broadcasting from the station...");
        subscribers?.Invoke("Hello, subscribers!");

        MessageEvt(this, new MessageEventArgs { Message = "Hello, subscribers!" }); 
    }
}

public class MessageEventArgs : EventArgs
{
    public string Message { get; set; }

}