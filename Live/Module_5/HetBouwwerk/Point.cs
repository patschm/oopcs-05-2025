namespace HetBouwwerk;

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point pa, Point pb)
    {
        return new Point { X = pa.X + pb.X, Y = pa.Y + pb.Y };
    }
    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
