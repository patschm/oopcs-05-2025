namespace HetCern;

delegate int MathDel(int a, int b);

internal class WillemKlein
{
    public void Bereken(MathDel opdracht, int x, int y)
    {
        Console.WriteLine("Willem gaat nu rekenen....");

        int result = opdracht(x, y);

        Console.WriteLine($"Eureka!! Het resultaat is :{result}");
    }
}
