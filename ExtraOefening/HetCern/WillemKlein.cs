
public delegate int MathDel(int a, int b);

public class WillemKlein
{
    public void Calculate(MathDel m, int xx, int yy)
    {
        System.Console.WriteLine("Willem Klein begint te rekenen:");
        int result = m(xx,yy);


        System.Console.WriteLine($"Het antwoord is: {result}");
    }
}