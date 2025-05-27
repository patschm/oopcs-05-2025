namespace MoreObjects;

public abstract class Lamp
{
    protected int _intensiteit = 200;

    public int Intensiteit
    {
        set
        {
            if (value > 0 && value < 2000)
            {
                _intensiteit = value;
            }
        }
        get
        {
            return _intensiteit;
        }
    }
    public ConsoleColor Kleur { set; get; } = ConsoleColor.DarkYellow;

    // Met virtual geef ik aan dat dit gedrag polymorf KAN zijn.
    // Een virtual methode mag overschreven, maar hoeft niet.
    //public virtual void Aan()
    //{
    //    Console.BackgroundColor = Kleur;
    //    Console.WriteLine($"De lamp is aan en brandt met een intensiteit van {_intensiteit}lm");
    //    Console.ResetColor();
    //}

    public abstract void Aan();
}