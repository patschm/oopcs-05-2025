
namespace DeRadio;

class Program
{
    static void Main(string[] args)
    {
        Station r538 = new Station();
        r538.Message += ViaSms;
        r538.Message += ViaEmail;
        r538.Message += ViaPushNotification;
        r538.Message += ViaEther;
        r538.Message += ViaRooksignalen;
        r538.Message += ViaPostduif;
        r538.Message += ViaSms;
        r538.Message += ViaEmail;
        r538.Message += ViaPushNotification;
        r538.Message += ViaEther;
        r538.Message += ViaRooksignalen;
        r538.Message += ViaPostduif;

        r538.MessageEvt += OnReceiveMessage;

        r538.Broadcast();
    }

    private static void OnReceiveMessage(object? sender, MessageEventArgs e)
    {
        System.Console.WriteLine(e.Message);
    }

    static void ViaSms(string message)
    {
        Console.WriteLine($"Via SMS: {message}");
    }
    static void ViaEmail(string message)
    {
        Console.WriteLine($"Via Email: {message}");
    }
    static void ViaPushNotification(string message)
    {
        Console.WriteLine($"Via Push Notification: {message}");
    }
    static void ViaEther(string message)
    {
        Console.WriteLine($"Via Ether: {message}");
    }
    static void ViaRooksignalen(string message)
    {
        Console.WriteLine($"Via Rooksignalen: {message}");
    }
    static void ViaPostduif(string message)
    {
        Console.WriteLine($"Via Postduif: {message}");
    }
}
