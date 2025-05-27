namespace HetBouwwerk;

static class Extensions
{
    public static void SponsoredBy(this int x, string name)
    {
        Console.WriteLine($"{x} is sponsored by {name}");
    }

    public static void Reset(this Point p)
    {
        p.X = 0;
        p.Y = 0;
    }
}
