namespace Generieken;

internal class Point<A>
{
    public A X { get; set; }
    public A Y { get; set; }


    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
